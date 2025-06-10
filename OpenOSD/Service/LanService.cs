using LibreHardwareMonitor.Hardware;
using OpenOSD.Service;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace OpenOSD.Entity
{
    public class LanService : BaseService
    {
        private LAN lan;
        private readonly Computer Computer;
        private static readonly HttpClient _httpClient = new HttpClient();

        public LanService(LAN lan)
        {
            this.lan = lan;
            this.Computer = this.GetComputer();
            this.Computer.Open();
            this.lan.InternalIP = GetLocalIPAddress();
        }

        private Computer GetComputer()
        {
            return new Computer { IsNetworkEnabled = true };
        }

        public void Update()
        {
            var defaultNicName = GetDefaultNetworkInterfaceName()?.ToLower();
      
            var networkHardware = this.Computer.Hardware.Where(hw => hw.HardwareType == HardwareType.Network).FirstOrDefault(hw => hw.Name.ToLower().Contains(defaultNicName));

            if (networkHardware != null)
            {
                var hardwareArray = new IHardware[] { networkHardware };
                
                string[] downloadSensors = { "download", "received", "rx" };
                this.lan.DownloadSpeedBps = this.GetValues(hardwareArray, SensorType.Throughput, downloadSensors);
                
                string[] uploadSensors = { "upload", "sent", "tx" };
                this.lan.UploadSpeedBps = this.GetValues(hardwareArray, SensorType.Throughput, uploadSensors);
            }
        }

        private string GetDefaultNetworkInterfaceName()
        {
            var defaultNic = NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up)
                .Where(nic => nic.GetIPProperties().GatewayAddresses
                    .Any(g => g.Address.AddressFamily == AddressFamily.InterNetwork))
                .FirstOrDefault();

            return defaultNic?.Name ?? "Desconhecida";
        }

        public async Task FetchExternalIPAsync()
        {
            try
            {
                string ip = await _httpClient.GetStringAsync("https://api.ipify.org");
                this.lan.ExternalIP = ip.Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter IP externo: {ex.Message}");
                this.lan.ExternalIP = "Desconhecido";
            }
        }

        private string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                var ipv4 = host.AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                return ipv4?.ToString() ?? "Desconhecido";
            }
            catch
            {
                return "Desconhecido";
            }
        }
    }
}