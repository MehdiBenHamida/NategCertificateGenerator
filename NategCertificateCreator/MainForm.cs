using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NategCertificateCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Compeleted);
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        void backgroundWorker_Compeleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void TemplateBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenTemplate.Filter = "PNG files (*.png)|*.png"; // check other types of images
            if (OpenTemplate.ShowDialog() == DialogResult.OK)
            {
                TemplatePath.Text = OpenTemplate.FileName;
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            Help.ShowDialog();
        }

        private void StandardPolice_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardPolice.Checked == true)
            {
                //disable advanced police button
                AdvancedPoliceBtn.Enabled = false;
            }
            else
            {
                //enable advanced police button 
                AdvancedPoliceBtn.Enabled = true;
            }
        }

        private void StandardCkeck_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardCkeck.Checked == true)
            {
                AdvancedBtn.Enabled = false;
            }
            else
            {
                AdvancedBtn.Enabled = true;
            }
        }

        private void CertifiedBrowse_Click(object sender, EventArgs e)
        {
            OpenCertifiedFile.Filter = "CSV files (*.csv)|*.csv";
            if (OpenCertifiedFile.ShowDialog() == DialogResult.OK)
            {
                CertifiedPath.Text = OpenCertifiedFile.FileName;
            }
        }

        private void OutputBrowseBtn_Click(object sender, EventArgs e)
        {
            if (OutputBrowse.ShowDialog() == DialogResult.OK) 
            {
                OutputPath.Text = OutputBrowse.SelectedPath;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker.CancelAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }
    }
}
