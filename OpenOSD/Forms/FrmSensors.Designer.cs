namespace OpenOSD
{
    partial class FrmSensors
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSensors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCpuName = new System.Windows.Forms.TextBox();
            this.LblVoltageValue = new System.Windows.Forms.Label();
            this.LblVoltage = new System.Windows.Forms.Label();
            this.PbVoltage = new MetroFramework.Controls.MetroProgressBar();
            this.LblTempValue = new System.Windows.Forms.Label();
            this.LblTemp = new System.Windows.Forms.Label();
            this.PgTemperature = new MetroFramework.Controls.MetroProgressBar();
            this.LblClockValue = new System.Windows.Forms.Label();
            this.LblUsage = new System.Windows.Forms.Label();
            this.PgClock = new MetroFramework.Controls.MetroProgressBar();
            this.LblCPU = new System.Windows.Forms.Label();
            this.CpuSpinner = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtGpuName = new System.Windows.Forms.TextBox();
            this.lblVramValue = new System.Windows.Forms.Label();
            this.LblVram = new System.Windows.Forms.Label();
            this.PbVram = new MetroFramework.Controls.MetroProgressBar();
            this.LblGpuTempValue = new System.Windows.Forms.Label();
            this.LblGpuTemp = new System.Windows.Forms.Label();
            this.PgGpuTemp = new MetroFramework.Controls.MetroProgressBar();
            this.LblGpuClockValue = new System.Windows.Forms.Label();
            this.LblGpuClock = new System.Windows.Forms.Label();
            this.PgGpuClock = new MetroFramework.Controls.MetroProgressBar();
            this.LblGPU = new System.Windows.Forms.Label();
            this.GpuSpinner = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.TimerDash = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblRamUsage = new System.Windows.Forms.Label();
            this.lblFreeRam = new System.Windows.Forms.Label();
            this.LblUsedRam = new System.Windows.Forms.Label();
            this.PbRam = new MetroFramework.Controls.MetroProgressBar();
            this.lblRamValue = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.LblClock = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblDown = new System.Windows.Forms.Label();
            this.LblUp = new System.Windows.Forms.Label();
            this.LblInternalIp = new System.Windows.Forms.Label();
            this.lblExternalIp = new System.Windows.Forms.Label();
            this.lblLAN = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnSettings = new System.Windows.Forms.PictureBox();
            this.TtDash = new System.Windows.Forms.ToolTip(this.components);
            this.TxtMoboName = new System.Windows.Forms.TextBox();
            this.NiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.CtxTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnMinimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSettings)).BeginInit();
            this.CtxTray.SuspendLayout();
            this.CtxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.TxtCpuName);
            this.panel1.Controls.Add(this.LblVoltageValue);
            this.panel1.Controls.Add(this.LblVoltage);
            this.panel1.Controls.Add(this.PbVoltage);
            this.panel1.Controls.Add(this.LblTempValue);
            this.panel1.Controls.Add(this.LblTemp);
            this.panel1.Controls.Add(this.PgTemperature);
            this.panel1.Controls.Add(this.LblClockValue);
            this.panel1.Controls.Add(this.LblUsage);
            this.panel1.Controls.Add(this.PgClock);
            this.panel1.Controls.Add(this.LblCPU);
            this.panel1.Controls.Add(this.CpuSpinner);
            this.panel1.Location = new System.Drawing.Point(23, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 227);
            this.panel1.TabIndex = 3;
            // 
            // TxtCpuName
            // 
            this.TxtCpuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TxtCpuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCpuName.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.TxtCpuName.ForeColor = System.Drawing.Color.White;
            this.TxtCpuName.Location = new System.Drawing.Point(80, 13);
            this.TxtCpuName.Name = "TxtCpuName";
            this.TxtCpuName.ReadOnly = true;
            this.TxtCpuName.Size = new System.Drawing.Size(320, 28);
            this.TxtCpuName.TabIndex = 15;
            this.TxtCpuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblVoltageValue
            // 
            this.LblVoltageValue.AutoSize = true;
            this.LblVoltageValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoltageValue.ForeColor = System.Drawing.Color.White;
            this.LblVoltageValue.Location = new System.Drawing.Point(365, 172);
            this.LblVoltageValue.Name = "LblVoltageValue";
            this.LblVoltageValue.Size = new System.Drawing.Size(35, 15);
            this.LblVoltageValue.TabIndex = 13;
            this.LblVoltageValue.Text = "0,00V";
            // 
            // LblVoltage
            // 
            this.LblVoltage.AutoSize = true;
            this.LblVoltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoltage.ForeColor = System.Drawing.Color.White;
            this.LblVoltage.Location = new System.Drawing.Point(200, 172);
            this.LblVoltage.Name = "LblVoltage";
            this.LblVoltage.Size = new System.Drawing.Size(91, 15);
            this.LblVoltage.TabIndex = 12;
            this.LblVoltage.Text = "Voltage (vCore):";
            // 
            // PbVoltage
            // 
            this.PbVoltage.Location = new System.Drawing.Point(203, 190);
            this.PbVoltage.Maximum = 140;
            this.PbVoltage.Name = "PbVoltage";
            this.PbVoltage.Size = new System.Drawing.Size(197, 23);
            this.PbVoltage.Style = MetroFramework.MetroColorStyle.Silver;
            this.PbVoltage.TabIndex = 11;
            this.PbVoltage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblTempValue
            // 
            this.LblTempValue.AutoSize = true;
            this.LblTempValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempValue.ForeColor = System.Drawing.Color.White;
            this.LblTempValue.Location = new System.Drawing.Point(359, 123);
            this.LblTempValue.Name = "LblTempValue";
            this.LblTempValue.Size = new System.Drawing.Size(41, 15);
            this.LblTempValue.TabIndex = 10;
            this.LblTempValue.Text = "00,0ºC";
            // 
            // LblTemp
            // 
            this.LblTemp.AutoSize = true;
            this.LblTemp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemp.ForeColor = System.Drawing.Color.White;
            this.LblTemp.Location = new System.Drawing.Point(200, 123);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.Size = new System.Drawing.Size(95, 15);
            this.LblTemp.TabIndex = 9;
            this.LblTemp.Text = "Temp (Package):";
            // 
            // PgTemperature
            // 
            this.PgTemperature.Location = new System.Drawing.Point(203, 141);
            this.PgTemperature.Name = "PgTemperature";
            this.PgTemperature.Size = new System.Drawing.Size(197, 23);
            this.PgTemperature.Style = MetroFramework.MetroColorStyle.Silver;
            this.PgTemperature.TabIndex = 8;
            this.PgTemperature.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblClockValue
            // 
            this.LblClockValue.AutoSize = true;
            this.LblClockValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClockValue.ForeColor = System.Drawing.Color.White;
            this.LblClockValue.Location = new System.Drawing.Point(352, 74);
            this.LblClockValue.Name = "LblClockValue";
            this.LblClockValue.Size = new System.Drawing.Size(48, 15);
            this.LblClockValue.TabIndex = 7;
            this.LblClockValue.Text = "0,00Ghz";
            // 
            // LblUsage
            // 
            this.LblUsage.AutoSize = true;
            this.LblUsage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsage.ForeColor = System.Drawing.Color.White;
            this.LblUsage.Location = new System.Drawing.Point(200, 74);
            this.LblUsage.Name = "LblUsage";
            this.LblUsage.Size = new System.Drawing.Size(40, 15);
            this.LblUsage.TabIndex = 6;
            this.LblUsage.Text = "Clock:";
            // 
            // PgClock
            // 
            this.PgClock.Location = new System.Drawing.Point(203, 92);
            this.PgClock.Maximum = 5800;
            this.PgClock.Name = "PgClock";
            this.PgClock.Size = new System.Drawing.Size(197, 23);
            this.PgClock.Style = MetroFramework.MetroColorStyle.Silver;
            this.PgClock.TabIndex = 5;
            this.PgClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblCPU
            // 
            this.LblCPU.AutoSize = true;
            this.LblCPU.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.LblCPU.ForeColor = System.Drawing.Color.White;
            this.LblCPU.Location = new System.Drawing.Point(10, 13);
            this.LblCPU.Name = "LblCPU";
            this.LblCPU.Size = new System.Drawing.Size(64, 35);
            this.LblCPU.TabIndex = 3;
            this.LblCPU.Text = "CPU";
            // 
            // CpuSpinner
            // 
            this.CpuSpinner.animated = false;
            this.CpuSpinner.animationIterval = 5;
            this.CpuSpinner.animationSpeed = 300;
            this.CpuSpinner.BackColor = System.Drawing.Color.Transparent;
            this.CpuSpinner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CpuSpinner.BackgroundImage")));
            this.CpuSpinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.CpuSpinner.ForeColor = System.Drawing.SystemColors.Window;
            this.CpuSpinner.LabelVisible = true;
            this.CpuSpinner.LineProgressThickness = 8;
            this.CpuSpinner.LineThickness = 5;
            this.CpuSpinner.Location = new System.Drawing.Point(10, 74);
            this.CpuSpinner.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CpuSpinner.MaxValue = 100;
            this.CpuSpinner.Name = "CpuSpinner";
            this.CpuSpinner.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CpuSpinner.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CpuSpinner.Size = new System.Drawing.Size(140, 140);
            this.CpuSpinner.TabIndex = 2;
            this.CpuSpinner.Value = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.TxtGpuName);
            this.panel2.Controls.Add(this.lblVramValue);
            this.panel2.Controls.Add(this.LblVram);
            this.panel2.Controls.Add(this.PbVram);
            this.panel2.Controls.Add(this.LblGpuTempValue);
            this.panel2.Controls.Add(this.LblGpuTemp);
            this.panel2.Controls.Add(this.PgGpuTemp);
            this.panel2.Controls.Add(this.LblGpuClockValue);
            this.panel2.Controls.Add(this.LblGpuClock);
            this.panel2.Controls.Add(this.PgGpuClock);
            this.panel2.Controls.Add(this.LblGPU);
            this.panel2.Controls.Add(this.GpuSpinner);
            this.panel2.Location = new System.Drawing.Point(444, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 227);
            this.panel2.TabIndex = 4;
            // 
            // TxtGpuName
            // 
            this.TxtGpuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TxtGpuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGpuName.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.TxtGpuName.ForeColor = System.Drawing.Color.White;
            this.TxtGpuName.Location = new System.Drawing.Point(79, 11);
            this.TxtGpuName.Name = "TxtGpuName";
            this.TxtGpuName.ReadOnly = true;
            this.TxtGpuName.Size = new System.Drawing.Size(320, 28);
            this.TxtGpuName.TabIndex = 16;
            this.TxtGpuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVramValue
            // 
            this.lblVramValue.AutoSize = true;
            this.lblVramValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVramValue.ForeColor = System.Drawing.Color.White;
            this.lblVramValue.Location = new System.Drawing.Point(350, 172);
            this.lblVramValue.Name = "lblVramValue";
            this.lblVramValue.Size = new System.Drawing.Size(49, 15);
            this.lblVramValue.TabIndex = 13;
            this.lblVramValue.Text = "1200MB";
            // 
            // LblVram
            // 
            this.LblVram.AutoSize = true;
            this.LblVram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVram.ForeColor = System.Drawing.Color.White;
            this.LblVram.Location = new System.Drawing.Point(199, 172);
            this.LblVram.Name = "LblVram";
            this.LblVram.Size = new System.Drawing.Size(43, 15);
            this.LblVram.TabIndex = 12;
            this.LblVram.Text = "VRAM:";
            // 
            // PbVram
            // 
            this.PbVram.Location = new System.Drawing.Point(202, 190);
            this.PbVram.Maximum = 12000;
            this.PbVram.Name = "PbVram";
            this.PbVram.Size = new System.Drawing.Size(197, 23);
            this.PbVram.Style = MetroFramework.MetroColorStyle.Silver;
            this.PbVram.TabIndex = 11;
            this.PbVram.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblGpuTempValue
            // 
            this.LblGpuTempValue.AutoSize = true;
            this.LblGpuTempValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGpuTempValue.ForeColor = System.Drawing.Color.White;
            this.LblGpuTempValue.Location = new System.Drawing.Point(367, 123);
            this.LblGpuTempValue.Name = "LblGpuTempValue";
            this.LblGpuTempValue.Size = new System.Drawing.Size(32, 15);
            this.LblGpuTempValue.TabIndex = 10;
            this.LblGpuTempValue.Text = "00ºC";
            // 
            // LblGpuTemp
            // 
            this.LblGpuTemp.AutoSize = true;
            this.LblGpuTemp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGpuTemp.ForeColor = System.Drawing.Color.White;
            this.LblGpuTemp.Location = new System.Drawing.Point(199, 123);
            this.LblGpuTemp.Name = "LblGpuTemp";
            this.LblGpuTemp.Size = new System.Drawing.Size(40, 15);
            this.LblGpuTemp.TabIndex = 9;
            this.LblGpuTemp.Text = "Temp:";
            // 
            // PgGpuTemp
            // 
            this.PgGpuTemp.Location = new System.Drawing.Point(202, 141);
            this.PgGpuTemp.Name = "PgGpuTemp";
            this.PgGpuTemp.Size = new System.Drawing.Size(197, 23);
            this.PgGpuTemp.Style = MetroFramework.MetroColorStyle.Silver;
            this.PgGpuTemp.TabIndex = 8;
            this.PgGpuTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblGpuClockValue
            // 
            this.LblGpuClockValue.AutoSize = true;
            this.LblGpuClockValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGpuClockValue.ForeColor = System.Drawing.Color.White;
            this.LblGpuClockValue.Location = new System.Drawing.Point(342, 74);
            this.LblGpuClockValue.Name = "LblGpuClockValue";
            this.LblGpuClockValue.Size = new System.Drawing.Size(57, 15);
            this.LblGpuClockValue.TabIndex = 7;
            this.LblGpuClockValue.Text = "0000 mhz";
            // 
            // LblGpuClock
            // 
            this.LblGpuClock.AutoSize = true;
            this.LblGpuClock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGpuClock.ForeColor = System.Drawing.Color.White;
            this.LblGpuClock.Location = new System.Drawing.Point(199, 74);
            this.LblGpuClock.Name = "LblGpuClock";
            this.LblGpuClock.Size = new System.Drawing.Size(40, 15);
            this.LblGpuClock.TabIndex = 6;
            this.LblGpuClock.Text = "Clock:";
            // 
            // PgGpuClock
            // 
            this.PgGpuClock.Location = new System.Drawing.Point(202, 92);
            this.PgGpuClock.Maximum = 3200;
            this.PgGpuClock.Name = "PgGpuClock";
            this.PgGpuClock.Size = new System.Drawing.Size(197, 23);
            this.PgGpuClock.Style = MetroFramework.MetroColorStyle.Silver;
            this.PgGpuClock.TabIndex = 5;
            this.PgGpuClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblGPU
            // 
            this.LblGPU.AutoSize = true;
            this.LblGPU.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.LblGPU.ForeColor = System.Drawing.Color.White;
            this.LblGPU.Location = new System.Drawing.Point(7, 10);
            this.LblGPU.Name = "LblGPU";
            this.LblGPU.Size = new System.Drawing.Size(66, 35);
            this.LblGPU.TabIndex = 3;
            this.LblGPU.Text = "GPU";
            // 
            // GpuSpinner
            // 
            this.GpuSpinner.animated = false;
            this.GpuSpinner.animationIterval = 5;
            this.GpuSpinner.animationSpeed = 300;
            this.GpuSpinner.BackColor = System.Drawing.Color.Transparent;
            this.GpuSpinner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GpuSpinner.BackgroundImage")));
            this.GpuSpinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.GpuSpinner.ForeColor = System.Drawing.SystemColors.Window;
            this.GpuSpinner.LabelVisible = true;
            this.GpuSpinner.LineProgressThickness = 8;
            this.GpuSpinner.LineThickness = 5;
            this.GpuSpinner.Location = new System.Drawing.Point(7, 74);
            this.GpuSpinner.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.GpuSpinner.MaxValue = 100;
            this.GpuSpinner.Name = "GpuSpinner";
            this.GpuSpinner.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.GpuSpinner.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GpuSpinner.Size = new System.Drawing.Size(140, 140);
            this.GpuSpinner.TabIndex = 2;
            this.GpuSpinner.Value = 0;
            // 
            // TimerDash
            // 
            this.TimerDash.Enabled = true;
            this.TimerDash.Interval = 1000;
            this.TimerDash.Tick += new System.EventHandler(this.TimerDash_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Controls.Add(this.LblRamUsage);
            this.panel3.Controls.Add(this.lblFreeRam);
            this.panel3.Controls.Add(this.LblUsedRam);
            this.panel3.Controls.Add(this.PbRam);
            this.panel3.Controls.Add(this.lblRamValue);
            this.panel3.Controls.Add(this.lblRAM);
            this.panel3.Location = new System.Drawing.Point(23, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 131);
            this.panel3.TabIndex = 7;
            // 
            // LblRamUsage
            // 
            this.LblRamUsage.AutoSize = true;
            this.LblRamUsage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRamUsage.ForeColor = System.Drawing.Color.White;
            this.LblRamUsage.Location = new System.Drawing.Point(328, 82);
            this.LblRamUsage.Name = "LblRamUsage";
            this.LblRamUsage.Size = new System.Drawing.Size(72, 37);
            this.LblRamUsage.TabIndex = 15;
            this.LblRamUsage.Text = "00%";
            // 
            // lblFreeRam
            // 
            this.lblFreeRam.AutoSize = true;
            this.lblFreeRam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeRam.ForeColor = System.Drawing.Color.White;
            this.lblFreeRam.Location = new System.Drawing.Point(23, 100);
            this.lblFreeRam.Name = "lblFreeRam";
            this.lblFreeRam.Size = new System.Drawing.Size(16, 15);
            this.lblFreeRam.TabIndex = 14;
            this.lblFreeRam.Text = "F:";
            // 
            // LblUsedRam
            // 
            this.LblUsedRam.AutoSize = true;
            this.LblUsedRam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsedRam.ForeColor = System.Drawing.Color.White;
            this.LblUsedRam.Location = new System.Drawing.Point(23, 82);
            this.LblUsedRam.Name = "LblUsedRam";
            this.LblUsedRam.Size = new System.Drawing.Size(19, 15);
            this.LblUsedRam.TabIndex = 13;
            this.LblUsedRam.Text = "U:";
            // 
            // PbRam
            // 
            this.PbRam.Location = new System.Drawing.Point(25, 55);
            this.PbRam.Name = "PbRam";
            this.PbRam.Size = new System.Drawing.Size(375, 23);
            this.PbRam.Style = MetroFramework.MetroColorStyle.Silver;
            this.PbRam.TabIndex = 12;
            this.PbRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblRamValue
            // 
            this.lblRamValue.AutoSize = true;
            this.lblRamValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamValue.ForeColor = System.Drawing.Color.White;
            this.lblRamValue.Location = new System.Drawing.Point(75, 22);
            this.lblRamValue.Name = "lblRamValue";
            this.lblRamValue.Size = new System.Drawing.Size(59, 30);
            this.lblRamValue.TabIndex = 4;
            this.lblRamValue.Text = "RAM";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.White;
            this.lblRAM.Location = new System.Drawing.Point(20, 22);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(62, 30);
            this.lblRAM.TabIndex = 3;
            this.lblRAM.Text = "RAM";
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.ForeColor = System.Drawing.Color.White;
            this.LblClock.Location = new System.Drawing.Point(396, 32);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(93, 40);
            this.LblClock.TabIndex = 8;
            this.LblClock.Text = "14:03";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.Controls.Add(this.LblDown);
            this.panel4.Controls.Add(this.LblUp);
            this.panel4.Controls.Add(this.LblInternalIp);
            this.panel4.Controls.Add(this.lblExternalIp);
            this.panel4.Controls.Add(this.lblLAN);
            this.panel4.Location = new System.Drawing.Point(444, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 131);
            this.panel4.TabIndex = 9;
            // 
            // LblDown
            // 
            this.LblDown.AutoSize = true;
            this.LblDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDown.ForeColor = System.Drawing.Color.White;
            this.LblDown.Location = new System.Drawing.Point(235, 84);
            this.LblDown.Name = "LblDown";
            this.LblDown.Size = new System.Drawing.Size(43, 15);
            this.LblDown.TabIndex = 17;
            this.LblDown.Text = "Down:";
            // 
            // LblUp
            // 
            this.LblUp.AutoSize = true;
            this.LblUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUp.ForeColor = System.Drawing.Color.White;
            this.LblUp.Location = new System.Drawing.Point(235, 69);
            this.LblUp.Name = "LblUp";
            this.LblUp.Size = new System.Drawing.Size(26, 15);
            this.LblUp.TabIndex = 16;
            this.LblUp.Text = "Up:";
            // 
            // LblInternalIp
            // 
            this.LblInternalIp.AutoSize = true;
            this.LblInternalIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInternalIp.ForeColor = System.Drawing.Color.White;
            this.LblInternalIp.Location = new System.Drawing.Point(24, 88);
            this.LblInternalIp.Name = "LblInternalIp";
            this.LblInternalIp.Size = new System.Drawing.Size(68, 15);
            this.LblInternalIp.TabIndex = 15;
            this.LblInternalIp.Text = "Internal IP:";
            // 
            // lblExternalIp
            // 
            this.lblExternalIp.AutoSize = true;
            this.lblExternalIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExternalIp.ForeColor = System.Drawing.Color.White;
            this.lblExternalIp.Location = new System.Drawing.Point(24, 69);
            this.lblExternalIp.Name = "lblExternalIp";
            this.lblExternalIp.Size = new System.Drawing.Size(70, 15);
            this.lblExternalIp.TabIndex = 14;
            this.lblExternalIp.Text = "External IP:";
            // 
            // lblLAN
            // 
            this.lblLAN.AutoSize = true;
            this.lblLAN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAN.ForeColor = System.Drawing.Color.White;
            this.lblLAN.Location = new System.Drawing.Point(20, 22);
            this.lblLAN.Name = "lblLAN";
            this.lblLAN.Size = new System.Drawing.Size(56, 30);
            this.lblLAN.TabIndex = 4;
            this.lblLAN.Text = "LAN";
            // 
            // PbLogo
            // 
            this.PbLogo.Location = new System.Drawing.Point(23, 14);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(153, 91);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 5;
            this.PbLogo.TabStop = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Image = global::OpenOSD.Properties.Resources.settings_245x256;
            this.BtnSettings.Location = new System.Drawing.Point(827, 47);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(25, 25);
            this.BtnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSettings.TabIndex = 10;
            this.BtnSettings.TabStop = false;
            this.TtDash.SetToolTip(this.BtnSettings, "Configurações");
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // TxtMoboName
            // 
            this.TxtMoboName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TxtMoboName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMoboName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TxtMoboName.ForeColor = System.Drawing.Color.White;
            this.TxtMoboName.Location = new System.Drawing.Point(284, 75);
            this.TxtMoboName.Name = "TxtMoboName";
            this.TxtMoboName.Size = new System.Drawing.Size(320, 15);
            this.TxtMoboName.TabIndex = 16;
            this.TxtMoboName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NiMain
            // 
            this.NiMain.ContextMenuStrip = this.CtxTray;
            this.NiMain.Text = "notifyIcon1";
            this.NiMain.Visible = true;
            this.NiMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NiMain_MouseDoubleClick);
            // 
            // CtxTray
            // 
            this.CtxTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSettingsToolStripMenuItem,
            this.BtnExitToolStripMenuItem});
            this.CtxTray.Name = "CtxTray";
            this.CtxTray.Size = new System.Drawing.Size(152, 48);
            // 
            // BtnSettingsToolStripMenuItem
            // 
            this.BtnSettingsToolStripMenuItem.Name = "BtnSettingsToolStripMenuItem";
            this.BtnSettingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.BtnSettingsToolStripMenuItem.Text = "Configurações";
            this.BtnSettingsToolStripMenuItem.Click += new System.EventHandler(this.BtnSettingsToolStripMenuItem_Click);
            // 
            // BtnExitToolStripMenuItem
            // 
            this.BtnExitToolStripMenuItem.Name = "BtnExitToolStripMenuItem";
            this.BtnExitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.BtnExitToolStripMenuItem.Text = "Sair";
            this.BtnExitToolStripMenuItem.Click += new System.EventHandler(this.BtnExitToolStripMenuItem_Click);
            // 
            // CtxMain
            // 
            this.CtxMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizeToolStripMenuItem});
            this.CtxMain.Name = "CtxMain";
            this.CtxMain.Size = new System.Drawing.Size(128, 26);
            // 
            // BtnMinimizeToolStripMenuItem
            // 
            this.BtnMinimizeToolStripMenuItem.Name = "BtnMinimizeToolStripMenuItem";
            this.BtnMinimizeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.BtnMinimizeToolStripMenuItem.Text = "Minimizar";
            this.BtnMinimizeToolStripMenuItem.Click += new System.EventHandler(this.BtnMinimizeToolStripMenuItem_Click);
            // 
            // FrmSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 493);
            this.ContextMenuStrip = this.CtxMain;
            this.ControlBox = false;
            this.Controls.Add(this.TxtMoboName);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSensors";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "OpenOSD";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmSensors_Load);
            this.Resize += new System.EventHandler(this.FrmSensors_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSettings)).EndInit();
            this.CtxTray.ResumeLayout(false);
            this.CtxMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCircleProgressbar CpuSpinner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCPU;
        private MetroFramework.Controls.MetroProgressBar PgClock;
        private System.Windows.Forms.Label LblUsage;
        private System.Windows.Forms.Label LblClockValue;
        private System.Windows.Forms.Label LblTempValue;
        private System.Windows.Forms.Label LblTemp;
        private MetroFramework.Controls.MetroProgressBar PgTemperature;
        private System.Windows.Forms.Label LblVoltageValue;
        private System.Windows.Forms.Label LblVoltage;
        private MetroFramework.Controls.MetroProgressBar PbVoltage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblGpuTempValue;
        private System.Windows.Forms.Label LblGpuTemp;
        private MetroFramework.Controls.MetroProgressBar PgGpuTemp;
        private System.Windows.Forms.Label LblGpuClockValue;
        private System.Windows.Forms.Label LblGpuClock;
        private MetroFramework.Controls.MetroProgressBar PgGpuClock;
        private System.Windows.Forms.Label LblGPU;
        private Bunifu.Framework.UI.BunifuCircleProgressbar GpuSpinner;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Timer TimerDash;
        private System.Windows.Forms.Label lblVramValue;
        private System.Windows.Forms.Label LblVram;
        private MetroFramework.Controls.MetroProgressBar PbVram;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRamValue;
        private System.Windows.Forms.Label lblRAM;
        private MetroFramework.Controls.MetroProgressBar PbRam;
        private System.Windows.Forms.Label LblUsedRam;
        private System.Windows.Forms.Label lblFreeRam;
        private System.Windows.Forms.Label LblRamUsage;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblInternalIp;
        private System.Windows.Forms.Label lblExternalIp;
        private System.Windows.Forms.Label lblLAN;
        private System.Windows.Forms.Label LblUp;
        private System.Windows.Forms.Label LblDown;
        private System.Windows.Forms.PictureBox BtnSettings;
        private System.Windows.Forms.ToolTip TtDash;
        private System.Windows.Forms.TextBox TxtCpuName;
        private System.Windows.Forms.TextBox TxtMoboName;
        private System.Windows.Forms.TextBox TxtGpuName;
        private System.Windows.Forms.NotifyIcon NiMain;
        private System.Windows.Forms.ContextMenuStrip CtxTray;
        private System.Windows.Forms.ToolStripMenuItem BtnSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnExitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CtxMain;
        private System.Windows.Forms.ToolStripMenuItem BtnMinimizeToolStripMenuItem;
    }
}

