using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NategCertificateCreator
{
    static class PoliceConfiguration
    {
        static private string _fontType { get; set; }
        static private int _fontSize { get; set; }
        static private Color _fontColor { get; set; }

        public static string FontType
        {
            get { return _fontType; }
            set { _fontType = value; }
        }

        public static int FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        public static Color FontColor
        {
            get { return _fontColor; }
            set { _fontColor = value; }
        }
    }
}
