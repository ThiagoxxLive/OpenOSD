namespace OpenOSD.Forms
{
    partial class FrmConfigs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblLogo = new MetroFramework.Controls.MetroLabel();
            this.TxtLogo = new MetroFramework.Controls.MetroTextBox();
            this.BtnSelectLogo = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnQuit = new MetroFramework.Controls.MetroButton();
            this.LblCpuTempTarget = new MetroFramework.Controls.MetroLabel();
            this.GpCpu = new System.Windows.Forms.GroupBox();
            this.LblCpuTargetTempValue = new MetroFramework.Controls.MetroLabel();
            this.SlCpuTargetTemp = new Bunifu.Framework.UI.BunifuSlider();
            this.LblCpuTempDiff = new MetroFramework.Controls.MetroLabel();
            this.LblCpuTargetClock = new MetroFramework.Controls.MetroLabel();
            this.LblCpuTempTargetColor = new MetroFramework.Controls.MetroLabel();
            this.CbCpuTempTarget = new MetroFramework.Controls.MetroComboBox();
            this.CbCpuTargetClock = new MetroFramework.Controls.MetroComboBox();
            this.LblCpuTargetClockColor = new MetroFramework.Controls.MetroLabel();
            this.TtSettings = new System.Windows.Forms.ToolTip(this.components);
            this.LblCpuTargetClockValue = new MetroFramework.Controls.MetroLabel();
            this.SlCpuTargetClock = new Bunifu.Framework.UI.BunifuSlider();
            this.LblCpuTempDiffValue = new MetroFramework.Controls.MetroLabel();
            this.SlCpuTempDiff = new Bunifu.Framework.UI.BunifuSlider();
            this.GpGpu = new System.Windows.Forms.GroupBox();
            this.LblGpuTargetClockValue = new MetroFramework.Controls.MetroLabel();
            this.SlGpuTargetClock = new Bunifu.Framework.UI.BunifuSlider();
            this.LblGpuTargetTempValue = new MetroFramework.Controls.MetroLabel();
            this.SlGpuTargetTemp = new Bunifu.Framework.UI.BunifuSlider();
            this.LblGpuTargetClock = new MetroFramework.Controls.MetroLabel();
            this.LblGpuTargetTempColor = new MetroFramework.Controls.MetroLabel();
            this.CbGpuTargetTemp = new MetroFramework.Controls.MetroComboBox();
            this.CbGpuTargetClock = new MetroFramework.Controls.MetroComboBox();
            this.LblGpuTargetClockColor = new MetroFramework.Controls.MetroLabel();
            this.LblGpuTargetTemp = new MetroFramework.Controls.MetroLabel();
            this.GpCpu.SuspendLayout();
            this.GpGpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Location = new System.Drawing.Point(23, 291);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(123, 19);
            this.LblLogo.Style = MetroFramework.MetroColorStyle.Black;
            this.LblLogo.TabIndex = 0;
            this.LblLogo.Text = "Logo da Tela Inicial:";
            this.LblLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TxtLogo
            // 
            this.TxtLogo.Location = new System.Drawing.Point(23, 313);
            this.TxtLogo.Name = "TxtLogo";
            this.TxtLogo.ReadOnly = true;
            this.TxtLogo.Size = new System.Drawing.Size(420, 23);
            this.TxtLogo.TabIndex = 1;
            this.TxtLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BtnSelectLogo
            // 
            this.BtnSelectLogo.Location = new System.Drawing.Point(449, 313);
            this.BtnSelectLogo.Name = "BtnSelectLogo";
            this.BtnSelectLogo.Size = new System.Drawing.Size(108, 23);
            this.BtnSelectLogo.TabIndex = 2;
            this.BtnSelectLogo.Text = "Selecionar";
            this.BtnSelectLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnSelectLogo.Click += new System.EventHandler(this.BtnSelectLogo_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(23, 342);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(140, 342);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(108, 23);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Sair";
            this.BtnQuit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblCpuTempTarget
            // 
            this.LblCpuTempTarget.AutoSize = true;
            this.LblCpuTempTarget.Location = new System.Drawing.Point(5, 19);
            this.LblCpuTempTarget.Name = "LblCpuTempTarget";
            this.LblCpuTempTarget.Size = new System.Drawing.Size(114, 19);
            this.LblCpuTempTarget.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempTarget.TabIndex = 5;
            this.LblCpuTempTarget.Text = "CPU Target Temp:";
            this.LblCpuTempTarget.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempTarget, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // GpCpu
            // 
            this.GpCpu.Controls.Add(this.LblCpuTempDiffValue);
            this.GpCpu.Controls.Add(this.SlCpuTempDiff);
            this.GpCpu.Controls.Add(this.LblCpuTargetClockValue);
            this.GpCpu.Controls.Add(this.SlCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTargetTempValue);
            this.GpCpu.Controls.Add(this.SlCpuTargetTemp);
            this.GpCpu.Controls.Add(this.LblCpuTempDiff);
            this.GpCpu.Controls.Add(this.LblCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTempTargetColor);
            this.GpCpu.Controls.Add(this.CbCpuTempTarget);
            this.GpCpu.Controls.Add(this.CbCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTargetClockColor);
            this.GpCpu.Controls.Add(this.LblCpuTempTarget);
            this.GpCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpCpu.ForeColor = System.Drawing.Color.Gray;
            this.GpCpu.Location = new System.Drawing.Point(23, 63);
            this.GpCpu.Name = "GpCpu";
            this.GpCpu.Size = new System.Drawing.Size(420, 225);
            this.GpCpu.TabIndex = 7;
            this.GpCpu.TabStop = false;
            this.GpCpu.Text = "Parâmetros CPU";
            // 
            // LblCpuTargetTempValue
            // 
            this.LblCpuTargetTempValue.AutoSize = true;
            this.LblCpuTargetTempValue.Location = new System.Drawing.Point(145, 39);
            this.LblCpuTargetTempValue.Name = "LblCpuTargetTempValue";
            this.LblCpuTargetTempValue.Size = new System.Drawing.Size(16, 19);
            this.LblCpuTargetTempValue.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTargetTempValue.TabIndex = 18;
            this.LblCpuTargetTempValue.Text = "0";
            this.LblCpuTargetTempValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTargetTempValue, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // SlCpuTargetTemp
            // 
            this.SlCpuTargetTemp.BackColor = System.Drawing.Color.Transparent;
            this.SlCpuTargetTemp.BackgroudColor = System.Drawing.Color.DarkGray;
            this.SlCpuTargetTemp.BorderRadius = 0;
            this.SlCpuTargetTemp.IndicatorColor = System.Drawing.Color.Gray;
            this.SlCpuTargetTemp.Location = new System.Drawing.Point(11, 37);
            this.SlCpuTargetTemp.MaximumValue = 125;
            this.SlCpuTargetTemp.Name = "SlCpuTargetTemp";
            this.SlCpuTargetTemp.Size = new System.Drawing.Size(128, 30);
            this.SlCpuTargetTemp.TabIndex = 17;
            this.SlCpuTargetTemp.Value = 0;
            this.SlCpuTargetTemp.ValueChanged += new System.EventHandler(this.SlCpuTargetTemp_ValueChanged);
            // 
            // LblCpuTempDiff
            // 
            this.LblCpuTempDiff.AutoSize = true;
            this.LblCpuTempDiff.Location = new System.Drawing.Point(5, 125);
            this.LblCpuTempDiff.Name = "LblCpuTempDiff";
            this.LblCpuTempDiff.Size = new System.Drawing.Size(99, 19);
            this.LblCpuTempDiff.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempDiff.TabIndex = 15;
            this.LblCpuTempDiff.Text = "CPU Temp Diff:";
            this.LblCpuTempDiff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempDiff, "Diferença de temperatura marcado no sensor da placa mãe ou AIDA64 para temperatur" +
        "a do sensor da aplicação. (Somente números)");
            // 
            // LblCpuTargetClock
            // 
            this.LblCpuTargetClock.AutoSize = true;
            this.LblCpuTargetClock.Location = new System.Drawing.Point(5, 70);
            this.LblCpuTargetClock.Name = "LblCpuTargetClock";
            this.LblCpuTargetClock.Size = new System.Drawing.Size(114, 19);
            this.LblCpuTargetClock.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTargetClock.TabIndex = 13;
            this.LblCpuTargetClock.Text = "CPU Target Clock:";
            this.LblCpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTargetClock, "Clock para trocar a cor da barra na tela de monitoramento. (Somente números)");
            // 
            // LblCpuTempTargetColor
            // 
            this.LblCpuTempTargetColor.AutoSize = true;
            this.LblCpuTempTargetColor.Location = new System.Drawing.Point(210, 12);
            this.LblCpuTempTargetColor.Name = "LblCpuTempTargetColor";
            this.LblCpuTempTargetColor.Size = new System.Drawing.Size(35, 19);
            this.LblCpuTempTargetColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempTargetColor.TabIndex = 12;
            this.LblCpuTempTargetColor.Text = "Cor:";
            this.LblCpuTempTargetColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempTargetColor, "Cor da barra de temperatura após ultrapassar o valor do campo ao lado.");
            // 
            // CbCpuTempTarget
            // 
            this.CbCpuTempTarget.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CbCpuTempTarget.FormattingEnabled = true;
            this.CbCpuTempTarget.ItemHeight = 19;
            this.CbCpuTempTarget.Location = new System.Drawing.Point(217, 34);
            this.CbCpuTempTarget.Name = "CbCpuTempTarget";
            this.CbCpuTempTarget.Size = new System.Drawing.Size(121, 25);
            this.CbCpuTempTarget.TabIndex = 11;
            this.CbCpuTempTarget.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CbCpuTargetClock
            // 
            this.CbCpuTargetClock.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CbCpuTargetClock.FormattingEnabled = true;
            this.CbCpuTargetClock.ItemHeight = 19;
            this.CbCpuTargetClock.Location = new System.Drawing.Point(217, 92);
            this.CbCpuTargetClock.Name = "CbCpuTargetClock";
            this.CbCpuTargetClock.Size = new System.Drawing.Size(121, 25);
            this.CbCpuTargetClock.TabIndex = 10;
            this.CbCpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblCpuTargetClockColor
            // 
            this.LblCpuTargetClockColor.AutoSize = true;
            this.LblCpuTargetClockColor.Location = new System.Drawing.Point(210, 70);
            this.LblCpuTargetClockColor.Name = "LblCpuTargetClockColor";
            this.LblCpuTargetClockColor.Size = new System.Drawing.Size(35, 19);
            this.LblCpuTargetClockColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTargetClockColor.TabIndex = 7;
            this.LblCpuTargetClockColor.Text = "Cor:";
            this.LblCpuTargetClockColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTargetClockColor, "Cor da barra de clock após ultrapassar o valor do campo ao lado.");
            // 
            // LblCpuTargetClockValue
            // 
            this.LblCpuTargetClockValue.AutoSize = true;
            this.LblCpuTargetClockValue.Location = new System.Drawing.Point(145, 94);
            this.LblCpuTargetClockValue.Name = "LblCpuTargetClockValue";
            this.LblCpuTargetClockValue.Size = new System.Drawing.Size(16, 19);
            this.LblCpuTargetClockValue.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTargetClockValue.TabIndex = 20;
            this.LblCpuTargetClockValue.Text = "0";
            this.LblCpuTargetClockValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTargetClockValue, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // SlCpuTargetClock
            // 
            this.SlCpuTargetClock.BackColor = System.Drawing.Color.Transparent;
            this.SlCpuTargetClock.BackgroudColor = System.Drawing.Color.DarkGray;
            this.SlCpuTargetClock.BorderRadius = 0;
            this.SlCpuTargetClock.IndicatorColor = System.Drawing.Color.Gray;
            this.SlCpuTargetClock.Location = new System.Drawing.Point(11, 92);
            this.SlCpuTargetClock.MaximumValue = 7000;
            this.SlCpuTargetClock.Name = "SlCpuTargetClock";
            this.SlCpuTargetClock.Size = new System.Drawing.Size(128, 30);
            this.SlCpuTargetClock.TabIndex = 19;
            this.SlCpuTargetClock.Value = 0;
            this.SlCpuTargetClock.ValueChanged += new System.EventHandler(this.SlCpuTargetClock_ValueChanged);
            // 
            // LblCpuTempDiffValue
            // 
            this.LblCpuTempDiffValue.AutoSize = true;
            this.LblCpuTempDiffValue.Location = new System.Drawing.Point(145, 149);
            this.LblCpuTempDiffValue.Name = "LblCpuTempDiffValue";
            this.LblCpuTempDiffValue.Size = new System.Drawing.Size(16, 19);
            this.LblCpuTempDiffValue.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempDiffValue.TabIndex = 22;
            this.LblCpuTempDiffValue.Text = "0";
            this.LblCpuTempDiffValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempDiffValue, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // SlCpuTempDiff
            // 
            this.SlCpuTempDiff.BackColor = System.Drawing.Color.Transparent;
            this.SlCpuTempDiff.BackgroudColor = System.Drawing.Color.DarkGray;
            this.SlCpuTempDiff.BorderRadius = 0;
            this.SlCpuTempDiff.IndicatorColor = System.Drawing.Color.Gray;
            this.SlCpuTempDiff.Location = new System.Drawing.Point(11, 147);
            this.SlCpuTempDiff.MaximumValue = 20;
            this.SlCpuTempDiff.Name = "SlCpuTempDiff";
            this.SlCpuTempDiff.Size = new System.Drawing.Size(128, 30);
            this.SlCpuTempDiff.TabIndex = 21;
            this.SlCpuTempDiff.Value = 0;
            this.SlCpuTempDiff.ValueChanged += new System.EventHandler(this.SlCpuTempDiff_ValueChanged);
            // 
            // GpGpu
            // 
            this.GpGpu.Controls.Add(this.LblGpuTargetClockValue);
            this.GpGpu.Controls.Add(this.SlGpuTargetClock);
            this.GpGpu.Controls.Add(this.LblGpuTargetTempValue);
            this.GpGpu.Controls.Add(this.SlGpuTargetTemp);
            this.GpGpu.Controls.Add(this.LblGpuTargetClock);
            this.GpGpu.Controls.Add(this.LblGpuTargetTempColor);
            this.GpGpu.Controls.Add(this.CbGpuTargetTemp);
            this.GpGpu.Controls.Add(this.CbGpuTargetClock);
            this.GpGpu.Controls.Add(this.LblGpuTargetClockColor);
            this.GpGpu.Controls.Add(this.LblGpuTargetTemp);
            this.GpGpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpGpu.ForeColor = System.Drawing.Color.Gray;
            this.GpGpu.Location = new System.Drawing.Point(449, 63);
            this.GpGpu.Name = "GpGpu";
            this.GpGpu.Size = new System.Drawing.Size(420, 225);
            this.GpGpu.TabIndex = 8;
            this.GpGpu.TabStop = false;
            this.GpGpu.Text = "Parâmetros CPU";
            // 
            // LblGpuTargetClockValue
            // 
            this.LblGpuTargetClockValue.AutoSize = true;
            this.LblGpuTargetClockValue.Location = new System.Drawing.Point(145, 94);
            this.LblGpuTargetClockValue.Name = "LblGpuTargetClockValue";
            this.LblGpuTargetClockValue.Size = new System.Drawing.Size(16, 19);
            this.LblGpuTargetClockValue.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetClockValue.TabIndex = 20;
            this.LblGpuTargetClockValue.Text = "0";
            this.LblGpuTargetClockValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetClockValue, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // SlGpuTargetClock
            // 
            this.SlGpuTargetClock.BackColor = System.Drawing.Color.Transparent;
            this.SlGpuTargetClock.BackgroudColor = System.Drawing.Color.DarkGray;
            this.SlGpuTargetClock.BorderRadius = 0;
            this.SlGpuTargetClock.IndicatorColor = System.Drawing.Color.Gray;
            this.SlGpuTargetClock.Location = new System.Drawing.Point(11, 92);
            this.SlGpuTargetClock.MaximumValue = 7000;
            this.SlGpuTargetClock.Name = "SlGpuTargetClock";
            this.SlGpuTargetClock.Size = new System.Drawing.Size(128, 30);
            this.SlGpuTargetClock.TabIndex = 19;
            this.SlGpuTargetClock.Value = 0;
            this.SlGpuTargetClock.ValueChanged += new System.EventHandler(this.SlGpuTargetClock_ValueChanged);
            // 
            // LblGpuTargetTempValue
            // 
            this.LblGpuTargetTempValue.AutoSize = true;
            this.LblGpuTargetTempValue.Location = new System.Drawing.Point(145, 39);
            this.LblGpuTargetTempValue.Name = "LblGpuTargetTempValue";
            this.LblGpuTargetTempValue.Size = new System.Drawing.Size(16, 19);
            this.LblGpuTargetTempValue.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetTempValue.TabIndex = 18;
            this.LblGpuTargetTempValue.Text = "0";
            this.LblGpuTargetTempValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetTempValue, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // SlGpuTargetTemp
            // 
            this.SlGpuTargetTemp.BackColor = System.Drawing.Color.Transparent;
            this.SlGpuTargetTemp.BackgroudColor = System.Drawing.Color.DarkGray;
            this.SlGpuTargetTemp.BorderRadius = 0;
            this.SlGpuTargetTemp.IndicatorColor = System.Drawing.Color.Gray;
            this.SlGpuTargetTemp.Location = new System.Drawing.Point(11, 37);
            this.SlGpuTargetTemp.MaximumValue = 95;
            this.SlGpuTargetTemp.Name = "SlGpuTargetTemp";
            this.SlGpuTargetTemp.Size = new System.Drawing.Size(128, 30);
            this.SlGpuTargetTemp.TabIndex = 17;
            this.SlGpuTargetTemp.Value = 0;
            this.SlGpuTargetTemp.ValueChanged += new System.EventHandler(this.SlGpuTargetTemp_ValueChanged);
            // 
            // LblGpuTargetClock
            // 
            this.LblGpuTargetClock.AutoSize = true;
            this.LblGpuTargetClock.Location = new System.Drawing.Point(5, 70);
            this.LblGpuTargetClock.Name = "LblGpuTargetClock";
            this.LblGpuTargetClock.Size = new System.Drawing.Size(114, 19);
            this.LblGpuTargetClock.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetClock.TabIndex = 13;
            this.LblGpuTargetClock.Text = "GPU Target Clock:";
            this.LblGpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetClock, "Clock para trocar a cor da barra na tela de monitoramento. (Somente números)");
            // 
            // LblGpuTargetTempColor
            // 
            this.LblGpuTargetTempColor.AutoSize = true;
            this.LblGpuTargetTempColor.Location = new System.Drawing.Point(210, 12);
            this.LblGpuTargetTempColor.Name = "LblGpuTargetTempColor";
            this.LblGpuTargetTempColor.Size = new System.Drawing.Size(35, 19);
            this.LblGpuTargetTempColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetTempColor.TabIndex = 12;
            this.LblGpuTargetTempColor.Text = "Cor:";
            this.LblGpuTargetTempColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetTempColor, "Cor da barra de temperatura após ultrapassar o valor do campo ao lado.");
            // 
            // CbGpuTargetTemp
            // 
            this.CbGpuTargetTemp.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CbGpuTargetTemp.FormattingEnabled = true;
            this.CbGpuTargetTemp.ItemHeight = 19;
            this.CbGpuTargetTemp.Location = new System.Drawing.Point(217, 34);
            this.CbGpuTargetTemp.Name = "CbGpuTargetTemp";
            this.CbGpuTargetTemp.Size = new System.Drawing.Size(121, 25);
            this.CbGpuTargetTemp.TabIndex = 11;
            this.CbGpuTargetTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CbGpuTargetClock
            // 
            this.CbGpuTargetClock.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CbGpuTargetClock.FormattingEnabled = true;
            this.CbGpuTargetClock.ItemHeight = 19;
            this.CbGpuTargetClock.Location = new System.Drawing.Point(217, 92);
            this.CbGpuTargetClock.Name = "CbGpuTargetClock";
            this.CbGpuTargetClock.Size = new System.Drawing.Size(121, 25);
            this.CbGpuTargetClock.TabIndex = 10;
            this.CbGpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblGpuTargetClockColor
            // 
            this.LblGpuTargetClockColor.AutoSize = true;
            this.LblGpuTargetClockColor.Location = new System.Drawing.Point(210, 70);
            this.LblGpuTargetClockColor.Name = "LblGpuTargetClockColor";
            this.LblGpuTargetClockColor.Size = new System.Drawing.Size(35, 19);
            this.LblGpuTargetClockColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetClockColor.TabIndex = 7;
            this.LblGpuTargetClockColor.Text = "Cor:";
            this.LblGpuTargetClockColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetClockColor, "Cor da barra de clock após ultrapassar o valor do campo ao lado.");
            // 
            // LblGpuTargetTemp
            // 
            this.LblGpuTargetTemp.AutoSize = true;
            this.LblGpuTargetTemp.Location = new System.Drawing.Point(5, 19);
            this.LblGpuTargetTemp.Name = "LblGpuTargetTemp";
            this.LblGpuTargetTemp.Size = new System.Drawing.Size(114, 19);
            this.LblGpuTargetTemp.Style = MetroFramework.MetroColorStyle.Black;
            this.LblGpuTargetTemp.TabIndex = 5;
            this.LblGpuTargetTemp.Text = "GPU Target Temp:";
            this.LblGpuTargetTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblGpuTargetTemp, "Temperatura para trocar a cor da barra na tela de monitoramento. (Somente números" +
        ")");
            // 
            // FrmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 388);
            this.Controls.Add(this.GpGpu);
            this.Controls.Add(this.GpCpu);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSelectLogo);
            this.Controls.Add(this.TxtLogo);
            this.Controls.Add(this.LblLogo);
            this.Name = "FrmConfigs";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Configurações";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmConfigs_Load);
            this.GpCpu.ResumeLayout(false);
            this.GpCpu.PerformLayout();
            this.GpGpu.ResumeLayout(false);
            this.GpGpu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblLogo;
        private MetroFramework.Controls.MetroTextBox TxtLogo;
        private MetroFramework.Controls.MetroButton BtnSelectLogo;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnQuit;
        private MetroFramework.Controls.MetroLabel LblCpuTempTarget;
        private System.Windows.Forms.GroupBox GpCpu;
        private MetroFramework.Controls.MetroLabel LblCpuTargetClockColor;
        private MetroFramework.Controls.MetroComboBox CbCpuTempTarget;
        private MetroFramework.Controls.MetroComboBox CbCpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblCpuTempTargetColor;
        private MetroFramework.Controls.MetroLabel LblCpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblCpuTempDiff;
        private System.Windows.Forms.ToolTip TtSettings;
        private Bunifu.Framework.UI.BunifuSlider SlCpuTargetTemp;
        private MetroFramework.Controls.MetroLabel LblCpuTargetTempValue;
        private MetroFramework.Controls.MetroLabel LblCpuTargetClockValue;
        private Bunifu.Framework.UI.BunifuSlider SlCpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblCpuTempDiffValue;
        private Bunifu.Framework.UI.BunifuSlider SlCpuTempDiff;
        private System.Windows.Forms.GroupBox GpGpu;
        private MetroFramework.Controls.MetroLabel LblGpuTargetClockValue;
        private Bunifu.Framework.UI.BunifuSlider SlGpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblGpuTargetTempValue;
        private Bunifu.Framework.UI.BunifuSlider SlGpuTargetTemp;
        private MetroFramework.Controls.MetroLabel LblGpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblGpuTargetTempColor;
        private MetroFramework.Controls.MetroComboBox CbGpuTargetTemp;
        private MetroFramework.Controls.MetroComboBox CbGpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblGpuTargetClockColor;
        private MetroFramework.Controls.MetroLabel LblGpuTargetTemp;
    }
}