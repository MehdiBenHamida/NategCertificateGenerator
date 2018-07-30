using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace NategCertificateCreator
{
    public partial class MainForm : Form
    {
        int AllLines;
        string CertificateOwner;
        Boolean isSuccess;

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
            const int MaxAttemps = 3;
            int Attemps;
            int progress = 0;
            try{
                using (System.IO.StreamReader file = new System.IO.StreamReader(CertifiedPath.Text))
                {
                    if (FileConfiguration.FileHeader)
                    {
                        file.ReadLine();
                    }
                    string line = file.ReadLine();
                    while ((line != null))
                    {
                        Attemps = 0;
                        string[] details = line.Split(FileConfiguration.Delimiter);
                        string Name;
                        if (BeautificationCheck.Checked)
                        {
                            Name = NameBeautification(details[0]);
                        }
                        else
                        {
                            Name = details[0];
                        }
                        CertificateOwner = Name;
                        Retry:
                            try
                            {
                                Attemps++;
                                using (Bitmap bitmap = (Bitmap)Image.FromFile(TemplatePath.Text))
                                {
                                    PointF Location = new PointF(float.Parse(PositionX.Text), float.Parse(PositionY.Text));
                                    using (Graphics graphics = Graphics.FromImage(bitmap))
                                    {
                                        using (Font font = new Font("Edwardian Script ITC", 48))
                                        {
                                            graphics.DrawString(Name, font, Brushes.Blue, Location);
                                        }
                                    }
                                    string registerPath = MakeRegisterPath(OutputPath.Text, Name + ".png");
                                    bitmap.Save(registerPath);
                                }
                                backgroundWorker.ReportProgress(progress);
                                isSuccess = true;
                            }
                            catch (Exception ep)
                            {
                                if (Attemps <= MaxAttemps)
                                {
                                    System.Threading.Thread.Sleep(Attemps * 500);
                                    goto Retry;
                                }
                                MessageBox.Show("Can not create certificate for: " + Name + "\n" + ep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                isSuccess = false;
                                break;
                            }
                        line = file.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int d;
            d = Convert.ToInt32(((double)e.ProgressPercentage / AllLines) * 100);
            CreationProgress.Value = d;
            ProgressLabel.Text = d.ToString() + " %";
            ProgressText.Text = "Creating certificate for: " + CertificateOwner;
        }

        void backgroundWorker_Compeleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isSuccess == true)
            {
                CreationProgress.Value = 100;
                ProgressLabel.Text = "100 %";
                ProgressText.Text = "All certificates are created succesfully!";
                string messages = "All certificates are created!";
                string captions = "Info";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(messages, captions, button, MessageBoxIcon.Information);
            }
            else
            {
                ProgressLabel.Text = "0 %";
                ProgressText.Text = "Certificate creation failed";
                CreationProgress.Value = 0;
            }
            CertificateBox.Enabled = true;
            CreateBtn.Enabled = true;
            ProgressBox.Enabled = false;
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

        private void AdvancedPoliceBtn_Click(object sender, EventArgs e)
        {
            PoliceConfigurationForm form = new PoliceConfigurationForm();
            form.ShowDialog();
        }

        private void AdvancedBtn_Click(object sender, EventArgs e)
        {
            FileConfigForm form = new FileConfigForm();
            form.ShowDialog();
        }

        private string NameBeautification(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Empty String");
            }
            else
            {
                string result = "";
                string[] words = name.ToLower().Split(' ');
                foreach (string word in words)
                {
                    result = result + word.First().ToString().ToUpper() + word.Substring(1) + " ";
                }
                return result;
            }
        }

        private string MakeRegisterPath(string OutputPath, string FileName)
        {
            bool exist = true;
            string result = "";
            string extention = Path.GetExtension(FileName);
            string BaseName = Path.GetFileName(FileName).Replace(extention, "");
            int i = 0;
            while (exist == true)
            {
                if (File.Exists(Path.Combine(OutputPath, FileName)))
                {
                    i++;
                    FileName = BaseName + "(" + i.ToString() + ")" + extention;
                }
                else
                {
                    result = Path.Combine(OutputPath, FileName);
                    exist = false;
                }
            }
            return result;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AllLines = File.ReadLines(CertifiedPath.Text).Count();
                CertificateBox.Enabled = false;
                CreateBtn.Enabled = false;
                ProgressBox.Enabled = true;
                backgroundWorker.RunWorkerAsync();
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
