using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please input the unit you want to convert: cm, m, in, or ft");
            string unit = Console.ReadLine();

            Console.WriteLine("Okay, now please input the amount");

            string num = Console.ReadLine();

            double x = double.Parse(num);

            switch (unit.Trim())
            {
                case "cm":
                    Convert(unit, x);
                    break;
                case "in":
                    Convert(unit, x);
                    break;
                case "m":
                    Convert(unit, x);
                    break;
                case "ft":
                    Convert(unit, x);
                    break;
            }
        }

        public static void Convert(string unit, double amount)
        {
            Console.WriteLine("Starting measurement: {0}: {1}", unit, amount);
            double m = 0, cm = 0, ft = 0, inches = 0;
            switch (unit)
            {
                case "cm":
                    m = amount / 100;
                    ft = amount / 30.48;
                    inches = amount / 2.54;
                    cm = amount;
                    break;

                case "in":
                    m = amount * 0.0254;
                    ft = amount / 12;
                    inches = amount;
                    cm = amount * 2.54;
                    break;
                case "ft":
                    m = amount / 3.281;
                    ft = amount;
                    inches = amount * 12;
                    cm = amount * 30.48;
                    break;
                case "m":
                    m = amount;
                    ft = amount * 3.28084;
                    inches = amount * 39.37008;
                    cm = amount * 100;
                    break;

            }

            Console.WriteLine("Result: ");
            Console.WriteLine("Cm: {0}", cm);
            Console.WriteLine("In: {0}", inches);
            Console.WriteLine("M: {0}", m);
            Console.WriteLine("Ft: {0}", ft);

        }

    }
}
