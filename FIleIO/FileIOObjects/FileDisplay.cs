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
        private StreamReader sr;
        public FileDisplay(string path)
        {
            this.path = path;
            sr = new StreamReader(path);
        }

        public string GetNextLine()
        {
            try
            {
                string output = sr.ReadLine();
                return output;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.HelpLink);
                return "Next Line not found";
            }
        }

        public string GetAllRemainingLines()
        {
            try
            {
                string output = sr.ReadToEnd();
                return output;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.HelpLink);
                return "No New Lines Found";
            }
            
        }

        public void CloseFile()
        {
            sr.Close();
        }
    }
}
