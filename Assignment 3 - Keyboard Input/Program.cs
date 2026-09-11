using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3___Keyboard_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.

            string name;
            int age, year;

            year = DateTime.Now.Year;

            Console.WriteLine("Hello, there! What's your name?");
            name = Console.ReadLine();
            if (name == "") 
            {
                Console.WriteLine("i KNOW YOU'VE GOT A NAME BIG GUY! But since you want to be different, we'll name you Muhammed since it's the most common name on earth.");
               
                name = "Muhammed";
            }

            Console.WriteLine($"Hey, {name}. How old are you?");
           
            if (Int32.TryParse(Console.ReadLine(), out age)) 
            {
                Console.WriteLine($"Ok, {name}! You are {age}, which means you were born in {year - age}!");
            }

            else if ( age >= 0)
            {

                Console.WriteLine($"Alright, {name}-You ain't funny, big guy.");

            }
            













        }
    }
}
