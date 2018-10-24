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
        public FileWriter(string path)
        {
            this.path = path;
        }

        public void OverWriteFile(string input)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(input);
            writer.Close();
        }

        public void AddToFile(string input)
        {
            StreamReader reader = new StreamReader(path);
            string fileText = reader.ReadToEnd();
            fileText = fileText + input;
            reader.Close();

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(fileText);

            writer.Close();
        }

    }
}
