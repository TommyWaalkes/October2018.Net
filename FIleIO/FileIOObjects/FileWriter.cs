using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOObjects
{
    class FileWriter
    {
        string path;
        StreamWriter sw;
        public FileWriter(string path)
        {
            this.path = path;
            sw = new StreamWriter(path);
        }

        public void WriteToFile(string input)
        {
            sw.Write(input);
        }

        public void Close()
        {
            sw.Close();
        }
    }
}
