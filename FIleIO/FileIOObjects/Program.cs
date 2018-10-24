using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //We need a file path, a full one, C# does not do relative paths 
            string path = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\_Code Examples\FIleIO\FIleIO\file2.txt";
            string path2 = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\_Code Examples\FIleIO\FIleIO\file.txt";
            FileDisplay fp = new FileDisplay(path);

            Console.WriteLine("This grabs it line by line");
            while (true)
            {
                string output1 = fp.GetNextLine();
                Console.WriteLine();
                Console.WriteLine(output1);
                if(output1== null)
                {
                    break;
                }
            }

            Console.WriteLine("This grabs it all at once: ");
            fp.CloseFile();

            fp = new FileDisplay(path);
            string output2 = fp.GetAllRemainingLines();
            Console.WriteLine(output2);


            FileWriter fw = new FileWriter(path2);

            string s = "Get off muh lawn ya dang kids";

            fw.WriteToFile(output2 + s);
            fw.Close();
        }
    }
}
