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
        }

        private void TemplateBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenTemplate.Filter = "PNG files (*.png)|*.png"; // check other types of images
            if (OpenTemplate.ShowDialog() == DialogResult.OK)
            {
                TemplatePath.Text = OpenTemplate.FileName;
            }
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

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            Help.ShowDialog();
        }
    }
}
