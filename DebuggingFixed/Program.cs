using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingFixed
{
    class Program
    {
        static void Main(string[] args)
        {
            // program counts vowels in a word! 
            int i = 0;
            int count = 0;

            string UserInput = Console.ReadLine();

            char[] Vowels = { 'a', 'e', 'i', 'u', 'o' };
            for (i = 0; i < UserInput.Length; i++)
            {
                for (int l = 0; l <= Vowels.Length; l++)
                {
                    if (UserInput[i] == Vowels[l])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
