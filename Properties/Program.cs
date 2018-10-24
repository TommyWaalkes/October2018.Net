using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            //This is the long way to handle vairables
            c.SetColor("red");
            Console.WriteLine("Our car is: " +c.GetColor());

            //This is the C# property way of doing this
            c.Make = "Chevy Ugo";
            Console.WriteLine("Our car's make is: " + c.Make);
        }
    }
}
