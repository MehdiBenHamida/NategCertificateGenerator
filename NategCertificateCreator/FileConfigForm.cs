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
    public partial class FileConfigForm : Form
    {
        public FileConfigForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (CommaRadio.Checked)
            {
                FileConfiguration.Delimiter = ',';
            }
            else if (SemiColonRadio.Checked)
            {
                FileConfiguration.Delimiter = ';';
            }
            else if (TabRadio.Checked)
            {
                FileConfiguration.Delimiter = '\t';
            }
            else if (SpaceRadio.Checked)
            {
                FileConfiguration.Delimiter = ' ';
            }
            if (HeaderCheck.Checked == true)
            {
                FileConfiguration.FileHeader = true;
            }
            else
            {
                FileConfiguration.FileHeader = false;
            }
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileConfigForm_Load(object sender, EventArgs e)
        {
            if (FileConfiguration.FileHeader == true)
            {
                HeaderCheck.Checked = true;
            }
            else
            {
                HeaderCheck.Checked = false;
            }
            if (FileConfiguration.Delimiter == ',')
            {
                CommaRadio.Checked = true;
            }
            else if (FileConfiguration.Delimiter == ';')
            {
                SemiColonRadio.Checked = true;
            }
            else if (FileConfiguration.Delimiter == '\t')
            {
                TabRadio.Checked = true;
            }
            else if (FileConfiguration.Delimiter == ' ')
            {
                SpaceRadio.Checked = true;
            }
        }
    }
}
