using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the script based way to do it.
            //File paths are tricky no matter what language or platform you're using them on
            //PRO-TIPS: there's a few different way to find a file path, right click on a file and select properties 
            //Or you can find it the file explorer and copy paste the url

            //PRO TIP: Go into your solution explorer and drag and drop a file in your project to where it needs to be 
            //IDK the file path, but visual studio does
            //string filePath = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\Code Examples\FIleIO\FIleIO\file2.txt";
            string filePath = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\_Code Examples\FIleIO\FIleIO\file2.txt";
            string path2 = @"C:\Users\Tommy\Documents\Visual Studio 2017\Projects\_Code Examples\FIleIO\FIleIO\file.txt";

            StreamWriter writer;
            StreamReader reader = new StreamReader(filePath);
            
            string input = reader.ReadToEnd();

            //File I/O and exceptions go hand in hand, there's bunch of exceptions that crop up 
            //with File I/O, but the most common would file not found 
            //which means one of two things: there is no file or your filepath is wrong 
            //This is part of why we need to be careful with our filepaths, and why we can't have nice things
            string lines = reader.ReadToEnd();
            Console.WriteLine("Read To End Method");
            Console.WriteLine(lines);
            try
            {
                // input = reader.ReadToEnd();
                //Console.Writeine(input);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //You can read a single line, goes until it sees a newline char
                    //Next time through the loop, it will give you the next line down
                    
                    Console.WriteLine(line);
                    //Is we're the end of the file then we'll break out of the loop
                    //If we're at the end (there's no lines left) then ReadLine() will return null
                    if (line == null)
                    {
                        Console.WriteLine("Line is null ");
                        break;
                    }
                }
                //Reader must close before another object can use the file 
                //What happens when we remove reader.Close()? 
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            try
            {
                //A Writer can put text into your file
                //Be careful here since you will overwrite what's already in the file 
                //It's always good to back up files your working with
                writer = new StreamWriter(filePath);

                    writer.Write(lines);
                    writer.WriteLine("Today was a good day ");
                    writer.WriteLine("I ate a hamburger");
                    writer.WriteLine("It was a boi");
                
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Instead of going line by line, you grab the contents of the file all at once 
            StreamReader reader2 = new StreamReader(filePath);
            reader2.Close();
            reader = new StreamReader(filePath);
            string text = reader.ReadToEnd();
            Console.WriteLine();
            Console.WriteLine("Read out of the whole file:");
            Console.WriteLine(text);
            reader.Close();

            //FUN FACT: While ints and number datatypes have limits to their datatype, strings can take up 
            //virtually unlimited space. You can dump all of War and Peace into a text file.
            //Your only limit on strings is that the space and processing power on your computer

        }
    }
}
