using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please input a word and I will tell what is or isn't a vowel");
            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();
            foreach(char l in letters)
            {
                bool b = IsVowel(l);
                if(b == true)
                {
                    Console.WriteLine(l + " is a vowel!");
                }
                else
                {
                    Console.WriteLine(l + " is not a vowel!" );
                }
            }
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            if (vowels.Contains(c))
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
