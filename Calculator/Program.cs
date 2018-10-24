using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            double x1 = 10;
            double y1 = 20;

            double x2 = 11;
            double y2 = 90;


            double x3 = c.Subtract(x1, x2);
            double y3 = c.Subtract(y1, y2);

            double squareX = c.Multiply(x3, x3);
            double squareY = c.Multiply(y3, y3);

            double sum = c.Add(squareX, squareY);

            double result = Math.Sqrt(sum);

            Console.WriteLine("The distance is: " + result);
        }
    }
}
