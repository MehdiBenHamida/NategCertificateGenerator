using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NategCertificateCreator
{
    static class Utilities
    {
        public static string MakeRegisterPath(string OutputPath, string FileName)
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

        public static string NameBeautification(string name)
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
                return result.Remove(result.Length - 1);
            }
        }
    }
}
