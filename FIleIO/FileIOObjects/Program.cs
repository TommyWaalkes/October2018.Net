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
            string path = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\_Code Examples\FIleIO\FileIOObjects\file2.txt";
            FileDisplay fp = new FileDisplay(path);

            Console.WriteLine("This grabs the string by index");
           
            string s = fp.GetSingleLine(0);
            Console.WriteLine(s);
            Console.WriteLine();


            Console.WriteLine("This grabs it all at once: ");

            string output2 = fp.GetAllRemainingLines();
            Console.WriteLine(output2);


            Console.WriteLine("Okay let's try to write to the file");

            FileWriter writer = new FileWriter(path);
            writer.AddToFile("I want a big mac");

            Console.WriteLine("Alright Let's check if it worked: ");
            Console.WriteLine();

            FileDisplay reader = new FileDisplay(path);

            Console.WriteLine(reader.GetAllRemainingLines());
        }
    }
}
