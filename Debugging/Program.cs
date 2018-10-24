using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            // program counts vowels in a word! 

            int i = 0;
            int count = 0;
            Console.WriteLine("Welcome to the grand circus Vowel counter. Input a word to count its vowels");
            string UserInput = Console.ReadLine();
            char[] UI = UserInput.ToCharArray();

            char[] Vowels = { 'a', 'e', 'i', 'u', 'o' };
            for (i = 0; i < UI.Length; i++)
            {
                for (int l = 0; l < Vowels.Length; l++)
                {
                    Console.WriteLine(UI[i]);
                    Console.WriteLine(Vowels[l]);
                    if (UI[i] == Vowels[l])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
