using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Hello! What is your name?");
                string name = Console.ReadLine();

                if (name.Length > 10)
                {
                    Console.WriteLine("Wow " + name + " you have a long name!");
                }
                else if (name.Length > 5)
                {
                    Console.WriteLine("Cool " + name + "! you have nice name!");
                }
                else if (name.Length > 0)
                {
                    Console.WriteLine("Woah " + name + "! you have a short name!");
                }
                else if(name.Length == 0)
                {
                    Console.WriteLine("You're a person with no name, may you get a fistful of dollars.");
                }
            }
        }
    }
}
