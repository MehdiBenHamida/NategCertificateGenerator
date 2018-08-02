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
            string OutputFile = Utilities.MakeRegisterPath(OutputPath.Text,  "OutputFile.csv");
            char Delimiter = ',';
            bool isHeader = false;
            string PoliceType = "Edwardian Script ITC";
            int PoliceSize = 48;
            Color PoliceColor = Color.Black;
            string registerPath;
            try
            {
                if (StandardCkeck.Checked)
                {
                    Delimiter = ',';
                    isHeader = false;
                }
                else
                {
                    Delimiter = FileConfiguration.Delimiter;
                    isHeader = FileConfiguration.FileHeader;
                }
                if (StandardPolice.Checked)
                {
                    PoliceType = "Edwardian Script ITC";
                    PoliceSize = 48;
                    PoliceColor = Color.Black;
                }
                else
                {
                    PoliceType = PoliceConfiguration.FontType;
                    PoliceSize = PoliceConfiguration.FontSize;
                    PoliceColor = PoliceConfiguration.FontColor;
                }
                using (System.IO.StreamReader file = new System.IO.StreamReader(CertifiedPath.Text))
                {
                    if (isHeader)
                    {
                        file.ReadLine();
                    }
                    string line = file.ReadLine();
                    while ((line != null))
                    {
                        Attemps = 0;
                        string[] details = line.Split(Delimiter);
                        string Name;
                        if (BeautificationCheck.Checked)
                        {
                            Name = Utilities.NameBeautification(details[0]);
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
                                        using (Font font = new Font(PoliceType, PoliceSize))
                                        {
                                            graphics.DrawString(Name, font, new SolidBrush(PoliceColor), Location);
                                        }
                                    }
                                    registerPath = Utilities.MakeRegisterPath(OutputPath.Text, Name + ".png");
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
                        if (OutputCheck.Checked)
                        {
                            using(StreamWriter ofile = new StreamWriter(OutputFile, true))
                            {
                                ofile.WriteLine(line + Delimiter + Path.GetFileName(registerPath));
                            }
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
