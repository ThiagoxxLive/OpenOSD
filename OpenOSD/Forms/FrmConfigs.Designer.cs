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
            this.TxtCpuTempDiff = new MetroFramework.Controls.MetroTextBox();
            this.LblCpuTempDiff = new MetroFramework.Controls.MetroLabel();
            this.TxtCpuTargetClock = new MetroFramework.Controls.MetroTextBox();
            this.LblCpuTargetClock = new MetroFramework.Controls.MetroLabel();
            this.LblCpuTempTargetColor = new MetroFramework.Controls.MetroLabel();
            this.TxtCpuTargetTemp = new MetroFramework.Controls.MetroTextBox();
            this.CbCpuTempTarget = new MetroFramework.Controls.MetroComboBox();
            this.CbCpuTargetClock = new MetroFramework.Controls.MetroComboBox();
            this.LblCpuTargetClockColor = new MetroFramework.Controls.MetroLabel();
            this.TtSettings = new System.Windows.Forms.ToolTip(this.components);
            this.GpCpu.SuspendLayout();
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
            this.TxtLogo.Size = new System.Drawing.Size(615, 23);
            this.TxtLogo.TabIndex = 1;
            this.TxtLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BtnSelectLogo
            // 
            this.BtnSelectLogo.Location = new System.Drawing.Point(644, 313);
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
            this.LblCpuTempTarget.Location = new System.Drawing.Point(2, 19);
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
            this.GpCpu.Controls.Add(this.TxtCpuTempDiff);
            this.GpCpu.Controls.Add(this.LblCpuTempDiff);
            this.GpCpu.Controls.Add(this.TxtCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTempTargetColor);
            this.GpCpu.Controls.Add(this.TxtCpuTargetTemp);
            this.GpCpu.Controls.Add(this.CbCpuTempTarget);
            this.GpCpu.Controls.Add(this.CbCpuTargetClock);
            this.GpCpu.Controls.Add(this.LblCpuTargetClockColor);
            this.GpCpu.Controls.Add(this.LblCpuTempTarget);
            this.GpCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpCpu.ForeColor = System.Drawing.Color.Gray;
            this.GpCpu.Location = new System.Drawing.Point(23, 63);
            this.GpCpu.Name = "GpCpu";
            this.GpCpu.Size = new System.Drawing.Size(269, 225);
            this.GpCpu.TabIndex = 7;
            this.GpCpu.TabStop = false;
            this.GpCpu.Text = "Parâmetros CPU";
            // 
            // TxtCpuTempDiff
            // 
            this.TxtCpuTempDiff.Location = new System.Drawing.Point(8, 147);
            this.TxtCpuTempDiff.Name = "TxtCpuTempDiff";
            this.TxtCpuTempDiff.Size = new System.Drawing.Size(121, 23);
            this.TxtCpuTempDiff.TabIndex = 16;
            this.TxtCpuTempDiff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtCpuTempDiff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpuTempDiff_KeyPress);
            // 
            // LblCpuTempDiff
            // 
            this.LblCpuTempDiff.AutoSize = true;
            this.LblCpuTempDiff.Location = new System.Drawing.Point(2, 125);
            this.LblCpuTempDiff.Name = "LblCpuTempDiff";
            this.LblCpuTempDiff.Size = new System.Drawing.Size(99, 19);
            this.LblCpuTempDiff.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempDiff.TabIndex = 15;
            this.LblCpuTempDiff.Text = "CPU Temp Diff:";
            this.LblCpuTempDiff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempDiff, "Diferença de temperatura marcado no sensor da placa mãe ou AIDA64 para temperatur" +
        "a do sensor da aplicação. (Somente números)");
            // 
            // TxtCpuTargetClock
            // 
            this.TxtCpuTargetClock.Location = new System.Drawing.Point(8, 92);
            this.TxtCpuTargetClock.Name = "TxtCpuTargetClock";
            this.TxtCpuTargetClock.Size = new System.Drawing.Size(121, 23);
            this.TxtCpuTargetClock.TabIndex = 14;
            this.TxtCpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtCpuTargetClock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpuTargetClock_KeyPress);
            // 
            // LblCpuTargetClock
            // 
            this.LblCpuTargetClock.AutoSize = true;
            this.LblCpuTargetClock.Location = new System.Drawing.Point(2, 70);
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
            this.LblCpuTempTargetColor.Location = new System.Drawing.Point(129, 16);
            this.LblCpuTempTargetColor.Name = "LblCpuTempTargetColor";
            this.LblCpuTempTargetColor.Size = new System.Drawing.Size(35, 19);
            this.LblCpuTempTargetColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTempTargetColor.TabIndex = 12;
            this.LblCpuTempTargetColor.Text = "Cor:";
            this.LblCpuTempTargetColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTempTargetColor, "Cor da barra de temperatura após ultrapassar o valor do campo ao lado.");
            // 
            // TxtCpuTargetTemp
            // 
            this.TxtCpuTargetTemp.Location = new System.Drawing.Point(8, 41);
            this.TxtCpuTargetTemp.Name = "TxtCpuTargetTemp";
            this.TxtCpuTargetTemp.Size = new System.Drawing.Size(121, 23);
            this.TxtCpuTargetTemp.TabIndex = 8;
            this.TxtCpuTargetTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtCpuTargetTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpuTarget_KeyPress);
            // 
            // CbCpuTempTarget
            // 
            this.CbCpuTempTarget.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CbCpuTempTarget.FormattingEnabled = true;
            this.CbCpuTempTarget.ItemHeight = 19;
            this.CbCpuTempTarget.Location = new System.Drawing.Point(135, 39);
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
            this.CbCpuTargetClock.Location = new System.Drawing.Point(135, 90);
            this.CbCpuTargetClock.Name = "CbCpuTargetClock";
            this.CbCpuTargetClock.Size = new System.Drawing.Size(121, 25);
            this.CbCpuTargetClock.TabIndex = 10;
            this.CbCpuTargetClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblCpuTargetClockColor
            // 
            this.LblCpuTargetClockColor.AutoSize = true;
            this.LblCpuTargetClockColor.Location = new System.Drawing.Point(129, 68);
            this.LblCpuTargetClockColor.Name = "LblCpuTargetClockColor";
            this.LblCpuTargetClockColor.Size = new System.Drawing.Size(35, 19);
            this.LblCpuTargetClockColor.Style = MetroFramework.MetroColorStyle.Black;
            this.LblCpuTargetClockColor.TabIndex = 7;
            this.LblCpuTargetClockColor.Text = "Cor:";
            this.LblCpuTargetClockColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TtSettings.SetToolTip(this.LblCpuTargetClockColor, "Cor da barra de clock após ultrapassar o valor do campo ao lado.");
            // 
            // FrmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 388);
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
        private MetroFramework.Controls.MetroTextBox TxtCpuTargetTemp;
        private MetroFramework.Controls.MetroLabel LblCpuTempTargetColor;
        private MetroFramework.Controls.MetroTextBox TxtCpuTargetClock;
        private MetroFramework.Controls.MetroLabel LblCpuTargetClock;
        private MetroFramework.Controls.MetroTextBox TxtCpuTempDiff;
        private MetroFramework.Controls.MetroLabel LblCpuTempDiff;
        private System.Windows.Forms.ToolTip TtSettings;
    }
}