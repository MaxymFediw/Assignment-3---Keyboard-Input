using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            Random Generator = new Random();

            string name;
            int age, year, num1, num2, num3, random1;
            double distance1, distance2, distance3, distanceTotal, side1, side2, hypotenuse;

            Generator.Next();

            year = DateTime.Now.Year;

            //Name, Age, Birth Year

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

            else if (age >= 0)
            {

                Console.WriteLine($"Alright, {name}-You ain't funny, big guy. Next time, enter a number, ok?");

            }

            Console.WriteLine();

            //Adder

            Console.WriteLine($"Ok, {name}-Give me a full number.");
            //num1 = Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine();
            }

            else if (num1 >= 0) 
            {

                num1 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {num1}.");
            }


                Console.WriteLine("Okay-Slide me another full number!");
            //num2 = Convert.ToInt32(Console.ReadLine());

            if (Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine();
            }

            else if (num2 >= 0)
            {

                num2 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {num2}.");
            }

            Console.WriteLine("Okay-One last full number!");
            //num3 = Convert.ToInt32(Console.ReadLine());

            if (Int32.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine();
            }

            else if (num3 >= 0)
            {

                num3 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {num3}.");
            }

            Console.WriteLine($"Ok, {name}! The total of your 3 numbers are: {num1 + num2 + num3}.");

            //Distance

            Console.WriteLine();

            Console.WriteLine($"Alright, {name}-Go ahead and throw me a distance in km.");
            //distance1 = Convert.ToDouble(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out distance1))
            {
                Console.WriteLine();
            }

            else if (distance1 >= 0)
            {

                distance1 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {distance1}.");
            }

            Console.WriteLine("Ok, another one now!");
            //distance2 = Convert.ToDouble(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out distance2))
            {
                Console.WriteLine();
            }

            else if (num3 >= 0)
            {

                distance2 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {distance2}.");
            }

            Console.WriteLine("Ok, one last distance!");


            if (double.TryParse(Console.ReadLine(), out distance3))
            {
                Console.WriteLine();
            }

            else if (distance3 >= 0)
            {

                distance3 = Generator.Next(1, 100);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {distance3}.");
            }

            distanceTotal = Math.Round((distance1 + distance2 + distance3) / 3, 2);

            Console.WriteLine($"Alright, {name}. The Average of your 3 distances is: {distanceTotal}km."); //(distance1 + distance2 + distance3) / 3}

            //Hypotenuse

            Console.WriteLine();

            Console.WriteLine($"Ok, {name}. This one is super serious! Give me a length of one side of a right-angled triangle.");
            //side1 = Convert.ToDouble(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out side1))
            {
                Console.WriteLine();
            }

            else if (side1 >= 0)
            {

                side1 = Generator.Next(1, 900);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {side1}.");
            }

            Console.WriteLine("Alrigt, Big Guy. Slide over that second side length.");
            //side2 = Convert.ToDouble(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out side2))
            {
                Console.WriteLine();
            }

            else if (side2 >= 0)
            {

                side2 = Generator.Next(1, 900);

                Console.WriteLine($"Since you want to be diferent, {name}, your number will be {side2}.");
            }

            hypotenuse = Math.Sqrt((Math.Pow(side1, 2)) + (Math.Pow(side2, 2)));

            hypotenuse = Math.Round(hypotenuse, 2);



            Console.WriteLine($"Alright, {name}-The hypotenuse of your triangle is: {hypotenuse}.");












        }
    }
}
