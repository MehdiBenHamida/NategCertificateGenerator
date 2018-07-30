using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NategCertificateCreator
{
    static class FileConfiguration
    {
        static private char _delimiter { get; set; }
        static private bool _fileHeader { get; set; }

        public static char Delimiter
        {
            get { return _delimiter; }
            set { _delimiter = value; }
        }
       
        public static bool FileHeader
        {
            get { return _fileHeader; }
            set { _fileHeader = value; }
        }

    }
}
