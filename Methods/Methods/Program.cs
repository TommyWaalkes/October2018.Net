using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( Bark() +" "+  Meow()+" " + One() +" "+ MakeSound("Moo")+" "+ MakeTwoSounds("Whee", "Chirp"));

            //Console.WriteLine( MakeTwoSounds());
            //string m = Meow();
            //Console.WriteLine(m);
            //string b = Bark();
            //Console.WriteLine(b);

            greet();
            string two = MakeTwoSounds("Moo", "Quack");
            Console.WriteLine(two);

            string fare = busFare( "Tommy", 1);

            Console.WriteLine(fare);
        }

        public static string busFare( string name, int cost)
        {
            string output = "Hello " + name + " your bus fare cost " + cost + " dollar(s)";

            return output;
        }

        public static string Meow()
        {
            return "Meow!";
        }

        public static string Bark()
        {
            string b = "Bark!";
            return b;
        }

        public static int One()
        {
            return 1;
        }

        public static string MakeSound(string noise)
        {
            string punctuation = "!";
            return noise + punctuation;
        }

        public static string WoofAndMeow()
        {
            return Bark() + Meow();
        }

        //Anything can be a parameter and anything can be a return type
        public static string MakeTwoSounds(string noise1, string noise2)
        {
            //Return passes out the data when it's called
            return noise1 + " " + noise2;
        }

        public static string MakeTwoSounds()
        {
            return "squak and squeak";
        }

        public static void greet()
        {
            Console.WriteLine("Hello There!");
            Console.WriteLine("We're here to make animal noises!");
        }
    }
}
