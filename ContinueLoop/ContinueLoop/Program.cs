using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run == true)
            {
                Console.WriteLine("Hello, Please input your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hi there "+name +"!");

                run = Continue();
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if(input == "y")
            {
                goOn = true;
            }
            else if(input == "n")
            {
                goOn = false;
            }
            else
            {
                //So this is a neat trick call recursion, it involves calling a method inside a method
                //In a sense it's another way of doing a loop, but using methods 
                //it works in much the same way, it's divided into two parts: 
                //a step and an end condition. 
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
