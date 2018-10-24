using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public Calculator()
        {

        }

        public double Add(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public double Subtract(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public double Multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }

        public double Divide(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
}
