using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int min = 1;
            int max = 7;
            //We're rolling a six sided dice here, how would you change it to a ten sided dice?
            Console.WriteLine("Random Object Example:");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(rng.Next(min, max));
                i++;
            }

            //So when we use a random object, we HAVE to use the same one and pass it around 
            //Why is that? And more importantly, what happens when we make a new random object each time we call the method?
            Console.WriteLine("Method Example:");
            i = 0;
            while (i < 10)
            {
                Console.WriteLine(RollDice(min, max, rng));
                i++;
            }

        }

        public static int RollDice(int min, int max, Random r)
        {
            //the .Next method includes the minimum, but excludes the maximum (meaning it will do every number up to it)
            //for example, say my min is 1 and my max is 7. The method will give me anything between 1 to 6, but not 7.
            
            int rando = r.Next(min, max);
            return rando;
        }
    }
}
