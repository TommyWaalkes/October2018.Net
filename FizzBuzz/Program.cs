using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello Please input a number");
                Console.WriteLine();
                string input = Console.ReadLine();
                int num = 0;
                if (int.TryParse(input, out num) && ValidateNum(num))
                {
                    int[] nums = { 3, 5, 7 };

                    Console.WriteLine(IsDivisibleByMultiple(nums, num));

                    if (IsDivisibleBy(5, num) && IsDivisibleBy(7, num) && IsDivisibleBy(3, num))
                    {
                        Console.WriteLine("Fizz Buzz Zip");
                    }
                    else if(IsDivisibleBy(5, num) && IsDivisibleBy(7, num))
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (IsDivisibleBy(5, num))
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (IsDivisibleBy(7, num))
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if(IsDivisibleBy(3, num))
                    {
                        Console.WriteLine("Zip");
                    }
                    else
                    {
                        Console.WriteLine("Not Divisible by our if statements");
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool IsDivisibleBy(int mod, int num)
        {
            bool output = num % mod == 0;
            return output;
        }

        public static bool IsDivisibleByMultiple(int[] mod, int num)
        {
            foreach(int n in mod)
            {
                bool isDivisible = IsDivisibleBy(n, num);
                if(isDivisible == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateNum(int n)
        {
            if(n >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
