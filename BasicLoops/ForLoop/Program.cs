using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop is starting!");

            // for (int i = 0; i<10; i++)
            sbyte i = 0;
           for(; ; )
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(i);
           
            Console.WriteLine("For Loop is over!");
            //Console.WriteLine(i);


            Console.WriteLine();


            Console.WriteLine("While Loop is starting!");
            bool run = true;
            int n = 0;
            while (run == true)
            {
                Console.WriteLine(n);
                n++;
                if (n >= 10)
                {
                    run = false;
                    
                }
            }
            Console.WriteLine("While Loop is done!");
        }
    }
}
