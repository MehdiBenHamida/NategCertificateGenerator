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
            List<string> sizes = new List<string>() { "8", "9", "10", "12", "14", "16", "18", "20", "22", 
                "24", "26", "28", "30", "32", "34", "36", "38", "40", "44", "48", "56", "66", "72", "86", "92" };
            foreach (string size in sizes)
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
            SampleText.Font = new Font(SampleText.Font.Name, (float)FontType.SelectedItem);
        }
    }
}
