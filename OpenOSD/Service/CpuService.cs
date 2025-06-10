using LibreHardwareMonitor.Hardware;
using OpenOSD.Service;
using System;
using System.Diagnostics;
using System.Linq;
using System.Management;

namespace OpenOSD.Entity
{
    public class CpuService : BaseService
    {
        private readonly Computer Computer;
        private CPU cpu;
        private readonly object _updateLock = new object();

        public CpuService(CPU cpu)
        {
            this.cpu = cpu;
            this.Computer = GetComputer();
            this.Computer.Open();
            this.cpu.MotherboardName = GetMotherboardName(this.Computer);            
        }

        private Computer GetComputer()
        {
            return new Computer
            {
                IsCpuEnabled = true,
                IsMotherboardEnabled = true,
            };
        }      

        public void Update()
        {
            lock (_updateLock)
            {

                var Hardware = this.Computer.Hardware.FirstOrDefault(hw => hw.HardwareType == HardwareType.Cpu);

                if (Hardware != null)
                {
                    this.cpu.Name = Hardware.Name;
                    this.cpu.Vendor = this.cpu.Name.IndexOf("Intel", StringComparison.OrdinalIgnoreCase) >= 0 ? "Intel" : "AMD";

                    this.cpu.Usage = this.GetCpuLoad(Hardware);
                    this.cpu.Temperature = this.GetPackageTemperature(this.Computer);
                    this.cpu.Clock = this.GetCurrentCpuClockSpeed();
                    this.cpu.Voltage = this.GetVcoreValue(this.Computer);
                }
            }
        }

        private float GetVcoreValue(Computer computer)
        {
            var Hardwares = computer.Hardware.Where(h => h.HardwareType == HardwareType.Motherboard).ToArray();
            return GetValues(Hardwares, SensorType.Voltage, new[] { "vcore" });
        }

        private float GetPackageTemperature(Computer computer)
        {
            var Hardwares = computer.Hardware.Where(h => h.HardwareType == HardwareType.Cpu).ToArray();
            return GetValues(Hardwares, SensorType.Temperature, new[] { "package", "ccd1", "tdie" }, subtractCpuTempDiff: true);
        }

        private int GetCpuLoad(IHardware hardware)
        {
            var loadSensor = hardware.Sensors.FirstOrDefault(s =>
                s.SensorType == SensorType.Load &&
                s.Name.ToLower().Contains("total"));

            return loadSensor?.Value.HasValue == true ? (int)Math.Round(loadSensor.Value.Value, 0) : 0;
        }

        public float GetCurrentCpuClockSpeed()
        {
            var searcher = new ManagementObjectSearcher("SELECT CurrentClockSpeed FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return (uint)(obj["CurrentClockSpeed"] ?? 0);
            }
            return 0;
        }

        private string GetMotherboardName(Computer computer)
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Motherboard)
                {
                    return hardware.Name;
                }
            }
            return "Desconhecido";
        }

        public double GetCpuClock()
        {
            using (PerformanceCounter cpuCounter = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total"))
            {

                cpuCounter.NextValue();
                System.Threading.Thread.Sleep(100);
                double cpuValue = cpuCounter.NextValue();

                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT *, Name FROM Win32_Processor").Get())
                {
                    double maxSpeedMhz = Convert.ToDouble(obj["MaxClockSpeed"]);
                    double turboSpeedMhz = maxSpeedMhz * cpuValue / 100;
                    return turboSpeedMhz / 1000.0;
                }
            }

            return 0;
        }        

        public void Close()
        {
            this.Computer.Close();
        }
    }
}