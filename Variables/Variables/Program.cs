using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //String consist of any character on your keyboard 
            //They can have letters, numbers, and symbols 
            //One other perk is that anything + a string will automatically convert the non string into a string

            String hello = "hello world";
            int money = 9000;
            Console.WriteLine(hello);

            hello = hello +" " + money;

            Console.WriteLine(hello);
            
            //Think of ints as your counting numbers 1,2,3,4 etc 
            //ints will be what you use when you want whole non-decimal numbers 
            //There are a few datatypes for handling decimals in C#, can you name 3? 
            int dayNumber = 1;
            double x = 3.5;
            Console.WriteLine("Today is day "+dayNumber);
            Console.WriteLine(dayNumber + "" + x );

            //Bools can only be true or false, like a yes or a no, or a 1 or a 0 
            //Bools are necessary for many things in programming 
            //Can you name two things that use bools?
            bool isRaining = false;
            Console.WriteLine("Is it raining today?");
            Console.WriteLine(!isRaining);

            Console.WriteLine("Hello there, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +name);

            //This line of code throw an error why? 
            //string duck = dayNumber + isRaining;
            
        }
    }
}
