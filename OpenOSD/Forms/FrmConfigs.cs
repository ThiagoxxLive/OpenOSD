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

            this.CbCpuTargetClock.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            this.CbCpuTempTarget.DataSource = Enum.GetValues(typeof (MetroColorStyle));
            this.TxtCpuTargetTemp.Text = Properties.Settings.Default.CpuTargetTemp.ToString() ?? "";
            this.TxtCpuTargetClock.Text = Properties.Settings.Default.CpuTargetClock.ToString() ?? "";
            this.TxtCpuTempDiff.Text = Properties.Settings.Default.CpuTempDiff.ToString() ?? "";

            this.GetValueFromEnum(this.CbCpuTempTarget, Properties.Settings.Default.CpuTargetTempColor);
            this.GetValueFromEnum(this.CbCpuTargetClock, Properties.Settings.Default.CpuTargetClockColor);
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
                Properties.Settings.Default.CpuTargetClock = Convert.ToInt32(this.TxtCpuTargetClock.Text);
                Properties.Settings.Default.CpuTargetTemp = Convert.ToInt32(this.TxtCpuTargetTemp.Text);
                Properties.Settings.Default.CpuTargetClockColor = this.CbCpuTargetClock.SelectedIndex.ToString();
                Properties.Settings.Default.CpuTargetTempColor = this.CbCpuTempTarget.SelectedIndex.ToString();
                Properties.Settings.Default.CpuTempDiff = Convert.ToInt32(this.TxtCpuTempDiff.Text);
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
    }
}
