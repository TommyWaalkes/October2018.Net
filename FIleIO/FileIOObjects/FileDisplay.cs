using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOObjects
{
    class FileDisplay
    {
        private string path;
      
        public FileDisplay(string path)
        {
            this.path = path;
        }

        public string GetSingleLine(int line)
        {
            StreamReader sr = new StreamReader(path);
            string output = sr.ReadToEnd();
            string[] lines = output.Split('\n');
            sr.Close();

            return lines[line];
        }

        public string GetAllRemainingLines()
        {
            StreamReader sr = new StreamReader(path);
            try
            {
               
                string output = sr.ReadToEnd();
                sr.Close();
                return output;
            }
            catch(Exception e)
            {
                sr.Close();
                Console.WriteLine(e.HelpLink);
                return "No New Lines Found";
            }
            
        }
    }
}
