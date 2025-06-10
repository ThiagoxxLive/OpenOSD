using MetroFramework;
using System;
using System.Windows.Forms;

namespace OpenOSD.Forms
{
    public partial class FrmConfigs : MetroFramework.Forms.MetroForm
    {        

        public FrmConfigs()
        {            
            InitializeComponent();
        }

        private void FrmConfigs_Load(object sender, EventArgs e)
        {
            this.LoadLogoPath();

            //Cpu Params
            this.CbCpuTargetClock.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            this.CbCpuTempTarget.DataSource = Enum.GetValues(typeof (MetroColorStyle));
            this.SlCpuTargetTemp.Value = Properties.Settings.Default.CpuTargetTemp;
            this.LblCpuTargetTempValue.Text = $"{Properties.Settings.Default.CpuTargetTemp} ºC" ?? "0";
            this.SlCpuTargetClock.Value = Properties.Settings.Default.CpuTargetClock;
            this.LblCpuTargetClockValue.Text = $"{Properties.Settings.Default.CpuTargetClock} MHz" ?? "0";
            this.SlCpuTempDiff.Value = Properties.Settings.Default.CpuTempDiff;
            this.LblCpuTempDiffValue.Text = $"{Properties.Settings.Default.CpuTempDiff}";
            this.GetValueFromEnum(this.CbCpuTempTarget, Properties.Settings.Default.CpuTargetTempColor);
            this.GetValueFromEnum(this.CbCpuTargetClock, Properties.Settings.Default.CpuTargetClockColor);

            //Gpu Params

            this.CbGpuTargetClock.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            this.CbGpuTargetTemp.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            this.SlGpuTargetTemp.Value = Properties.Settings.Default.GpuTargetTemp;
            this.LblGpuTargetTempValue.Text = Properties.Settings.Default.GpuTargetTemp.ToString() ?? "0";
            this.SlGpuTargetClock.Value = Properties.Settings.Default.GpuTargetClock;
            this.LblGpuTargetClockValue.Text = Properties.Settings.Default.GpuTargetClock.ToString() ?? "";
            this.GetValueFromEnum(this.CbGpuTargetTemp, Properties.Settings.Default.GpuTargetTempColor);
            this.GetValueFromEnum(this.CbGpuTargetClock, Properties.Settings.Default.GpuTargetTempColor);

        }

        private void LoadLogoPath()
        {
            var path = Properties.Settings.Default.LogoPath;

            if (path != null)
            {
                this.TxtLogo.Text = path;
            }
        }

        private void BtnSelectLogo_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();            
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.TxtLogo.Text = ofd.FileName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.LogoPath = TxtLogo.Text;

                //CPU Params
                Properties.Settings.Default.CpuTargetClock = this.SlCpuTargetClock.Value;
                Properties.Settings.Default.CpuTargetTemp = this.SlCpuTargetTemp.Value;
                Properties.Settings.Default.CpuTargetClockColor = this.CbCpuTargetClock.SelectedIndex.ToString();
                Properties.Settings.Default.CpuTargetTempColor = this.CbCpuTempTarget.SelectedIndex.ToString();
                Properties.Settings.Default.CpuTempDiff = this.SlCpuTempDiff.Value;

                //GPU Params
                Properties.Settings.Default.GpuTargetTemp = this.SlGpuTargetTemp.Value;
                Properties.Settings.Default.GpuTargetClock = this.SlGpuTargetClock.Value;
                Properties.Settings.Default.GpuTargetClockColor = this.CbGpuTargetClock.SelectedIndex.ToString();
                Properties.Settings.Default.GpuTargetTempColor = this.CbGpuTargetTemp.SelectedIndex.ToString();

                Properties.Settings.Default.Save();

                MessageBox.Show("As configurações foram salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Properties.Settings.Default.Reload();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair da aplicação?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();            
            }
        }
     

        private void GetValueFromEnum(ComboBox comboBox, string savedValue, MetroColorStyle defaultStyle = MetroColorStyle.Green)
        {            
            if (comboBox.DataSource == null)
            {
                comboBox.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            }
            
            if (Enum.TryParse(savedValue, out MetroColorStyle savedStyle))
            {                
                comboBox.SelectedItem = savedStyle;
            }
            else
            {                
                comboBox.SelectedItem = defaultStyle;
            }
        }

        private void TxtCpuTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IsNumericOnly(e);
        }

        private void TxtCpuTargetClock_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IsNumericOnly(e);
        }        

        private void TxtCpuTempDiff_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IsNumericOnly(e);
        }

        private void IsNumericOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SlCpuTargetTemp_ValueChanged(object sender, EventArgs e)
        {
            this.LblCpuTargetTempValue.Text = $"{this.SlCpuTargetTemp.Value} ºC";
        }

        private void SlCpuTargetClock_ValueChanged(object sender, EventArgs e)
        {
            this.LblCpuTargetClockValue.Text = $"{this.SlCpuTargetClock.Value} MHz";
        }

        private void SlCpuTempDiff_ValueChanged(object sender, EventArgs e)
        {
            this.LblCpuTempDiffValue.Text = this.SlCpuTempDiff.Value.ToString();
        }

        private void SlGpuTargetTemp_ValueChanged(object sender, EventArgs e)
        {
            this.LblGpuTargetTempValue.Text = SlGpuTargetTemp.Value.ToString();
        }

        private void SlGpuTargetClock_ValueChanged(object sender, EventArgs e)
        {
            this.LblGpuTargetClockValue.Text = SlGpuTargetClock.Value.ToString();
        }
    }
}
