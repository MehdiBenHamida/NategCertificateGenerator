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
    public partial class PoliceConfigurationForm : Form
    {
        public PoliceConfigurationForm()
        {
            InitializeComponent();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                FontType.Items.Add(font.Name);
            }
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                FontColor.Items.Add(color);
            }
            List<float> sizes = new List<float>() { 8, 9, 10, 12, 14, 16, 18, 20, 22, 
                24, 26, 28, 30, 32, 34, 36, 38, 40, 44, 48, 56, 66, 72, 86, 92 };
            foreach (float size in sizes)
            {
                FontSize.Items.Add(size);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            SampleText.Font =  new Font((string)FontType.SelectedItem, SampleText.Font.Size);
        }

        private void FontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color SelectedColor = Color.FromKnownColor((KnownColor)FontColor.SelectedItem);
            SampleText.ForeColor = SelectedColor;
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SampleText.Font = new Font(SampleText.Font.Name, (float)FontSize.SelectedItem);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

        }

        private void BoldCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BoldCheck.Checked == true)
            {
                if (ItalicCheck.Checked == false)
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Bold);
                }
                else
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold);                    
                }
            }
            else
            {
                if (ItalicCheck.Checked == false)
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Italic); 
                }
            }
        }

        private void ItalicCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ItalicCheck.Checked == true)
            {
                if (BoldCheck.Checked == false)
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Italic);

                }
                else
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold);
                }
            }
            else
            {
                if (BoldCheck.Checked == false)
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    SampleText.Font = new Font(SampleText.Font.Name, SampleText.Font.Size, System.Drawing.FontStyle.Bold);
                }
            }
        }
    }
}
