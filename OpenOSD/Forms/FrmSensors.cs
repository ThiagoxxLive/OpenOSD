using Autofac;
using MetroFramework;
using OpenOSD.Entity;
using OpenOSD.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpenOSD
{
    public partial class FrmSensors : MetroFramework.Forms.MetroForm
    {
        private readonly CpuService CpuService;
        private readonly CPU cpu;
        private readonly GpuService GpuService;
        private readonly GPU gpu;
        private readonly RamService RamService;
        private readonly RAM ram;
        private readonly LanService LanService;
        private readonly LAN lan;
        private readonly ILifetimeScope _scope;

        public FrmSensors(
            CpuService CpuService,
            CPU cpu,
            GpuService GpuService,
            GPU gpu,
            RamService RamService,
            RAM ram,
            LanService LanService,
            LAN lan,
            ILifetimeScope scope
        )
        {
            InitializeComponent();

            this.CpuService = CpuService;
            this.cpu = cpu;
            this.GpuService = GpuService;
            this.gpu = gpu;
            this.RamService = RamService;
            this.ram = ram;
            this.LanService = LanService;
            this.lan = lan;
            this._scope = scope;
        }

        private void FrmSensors_Load(object sender, EventArgs e)
        {
            this.LoadLogo();
            this.LblClock.Text = DateTime.Now.ToString("HH:mm");
        }

        private void LoadLogo()
        {
            var path = Properties.Settings.Default.LogoPath;

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                this.PbLogo.Image = Image.FromFile(path);
                
                using (var bmp = new Bitmap(path))
                {
                    IntPtr hIcon = bmp.GetHicon();
                    this.Icon = Icon.FromHandle(hIcon);
                }
            }
        }

        private async void TimerDash_Tick(object sender, EventArgs e)
        {
            var cpuTask = Task.Run(() => UpdateCpu());
            var gpuTask = Task.Run(() => UpdateGpu());
            var ramTask = Task.Run(() => UpdateRam());
            var lanTask = Task.Run(() => UpdateLan());

            await Task.WhenAll(cpuTask, gpuTask, ramTask, lanTask);
        }

        private void UpdateCpu()
        {
            CpuService.Update();

            double cpuClock = CpuService.GetCpuClock();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateCpuControls(CpuService, cpuClock);
                }));
            }
            else
            {
                UpdateCpuControls(CpuService, cpuClock);
            }
        }

        private void UpdateCpuControls(CpuService cpu, double cpuClock)
        {

            this.TxtMoboName.Text = this.cpu.MotherboardName;
            this.TxtCpuName.Text = this.cpu.Name;

            this.CpuSpinner.Value = this.cpu.Usage;

            int cpuClockMhz = (int)Math.Round(cpuClock * 1000);
            this.PgClock.Value = Math.Min(PgClock.Maximum, Math.Max(PgClock.Minimum, cpuClockMhz));

            this.PgClock.Style = cpuClockMhz >= Properties.Settings.Default.CpuTargetClock ? this.HandleStyleFromString(Properties.Settings.Default.CpuTargetClockColor) : MetroColorStyle.Silver;
            this.PgTemperature.Style = this.cpu.Temperature >= Properties.Settings.Default.CpuTargetTemp ? this.HandleStyleFromString(Properties.Settings.Default.CpuTargetTempColor) : MetroColorStyle.Green;

            LblClockValue.Text = $"{cpuClock:F2} GHz";
            this.LblTempValue.Text = $"{this.cpu.Temperature:F1} ºC";

            this.PgTemperature.Minimum = 0;
            this.PgTemperature.Maximum = 100;
            this.PgTemperature.Value = (int)Math.Round(this.cpu.Temperature);

            this.LblVoltageValue.Text = $"{this.cpu.Voltage:F2} V";
            this.PbVoltage.Value = (int)Math.Round(this.cpu.Voltage * 100);
        }


        private void UpdateGpu()
        {
            this.GpuService.Update();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateGpuControls(this.GpuService)));
            }
            else
            {
                UpdateGpuControls(this.GpuService);
            }
        }

        private void UpdateGpuControls(GpuService gpu)
        {
            TxtGpuName.Text = this.gpu.Name;

            GpuSpinner.Value = this.gpu.Usage;

            PgGpuClock.Value = Math.Min(PgGpuClock.Maximum, Math.Max(PgGpuClock.Minimum, (int)Math.Round(this.gpu.Clock)));
            LblGpuClockValue.Text = $"{this.gpu.Clock:F0} MHz";

            this.PgGpuClock.Style = this.gpu.Clock >= Properties.Settings.Default.GpuTargetClock ? this.HandleStyleFromString(Properties.Settings.Default.GpuTargetClockColor) : MetroColorStyle.Silver;
            this.PgGpuTemp.Style = this.gpu.Temperature >= Properties.Settings.Default.GpuTargetTemp ? this.HandleStyleFromString(Properties.Settings.Default.GpuTargetTempColor) : MetroColorStyle.Green; 

            PgGpuTemp.Value = Math.Min(PgGpuTemp.Maximum, Math.Max(PgGpuTemp.Minimum, (int)Math.Round(this.gpu.Temperature)));
            LblGpuTempValue.Text = $"{this.gpu.Temperature:0.#} ºC";            

            PbVram.Value = (int)Math.Round(this.gpu.Vram);
            lblVramValue.Text = $"{Math.Round(this.gpu.Vram).ToString()} MB";
        }


        private void UpdateRam()
        {
            this.RamService.Update();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateRamControls(this.RamService)));
            }
            else
            {
                UpdateRamControls(this.RamService);
            }
        }
        private void UpdateRamControls(RamService ram)
        {
            this.lblRamValue.Text = this.ram.GetModel();
            this.PbRam.Value = this.ram.UsedMemoryPercent;
            this.LblRamUsage.Text = $"{this.ram.UsedMemoryPercent.ToString()}%";
            this.LblUsedRam.Text = $"Used:                 {this.ram.UsedMemoryGb.ToString()} GB";
            this.lblFreeRam.Text = $"Free:                  {this.ram.FreeMemoryGb.ToString()} GB";
        }
        
        private async void UpdateLan()
        {

            this.LanService.Update();

            await this.LanService.FetchExternalIPAsync();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateLanControls(this.LanService);
                }));
            }
            else
            {
                UpdateLanControls(this.LanService);
            }
        }

        private void UpdateLanControls(LanService lan)
        {
            this.lblExternalIp.Text = $"External IP: {this.lan.ExternalIP.ToString()}";
            this.LblInternalIp.Text = $"Internal IP: {this.lan.InternalIP.ToString()}";
            
            this.LblUp.Text = $"Up: {(this.lan.UploadMBps * 8).ToString("F2")} Mbps";
            this.LblDown.Text = $"Down: {(this.lan.DownloadMBps * 8).ToString("F2")} Mbps";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.CpuService?.Close();
            this.GpuService?.Close();            
            base.OnFormClosing(e);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            using (var frmConfigs = this._scope.Resolve<FrmConfigs>())
            {
                frmConfigs.ShowDialog();
            }
        }

        private MetroColorStyle HandleStyleFromString(string styleName, MetroColorStyle defaultStyle = MetroColorStyle.Green)
        {
            if (Enum.TryParse(styleName, out MetroColorStyle parsedStyle))
            {
                return parsedStyle;
            }
            return defaultStyle;
        }
    }
}
