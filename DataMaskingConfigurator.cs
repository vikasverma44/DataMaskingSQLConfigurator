using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

namespace DataMaskingConfigurator
{
    public partial class DataMaskingConfigurator : Form
    {
        private readonly string MaskingConfigSourcePath;

        #region Form Constructor & Events

        public DataMaskingConfigurator()
        {
            InitializeComponent();
            MaskingConfigSourcePath = Convert.ToString(ConfigurationManager.AppSettings["ConfigurationSourcePath"]);
        }
        private void DataMaskingConfigurator_Load(object sender, EventArgs e)
        {

            AssemblyName asm = Assembly.GetExecutingAssembly().GetName();
            string version = string.Format("{0}.{1}", asm.Version.Major, asm.Version.Minor);
            this.Text = string.Format("Data Masking SQL Configurator (v{0})", version);

        }


        #endregion

        #region Form Control Events

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
       

        #endregion

        #region Private Methods

        private void SetControlsVisibility()
        {

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
