using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Conditionals
{
    public static class ConditionalsPractice
    {
        public static void Conditional1()
        {
            Console.WriteLine("How many dogs do you have?");
            var input = Console.ReadLine();
            var doggos = Convert.ToInt32(input);
            if (doggos < 1)
                Console.WriteLine("You need a doggo!");
            else if (doggos >= 1 && doggos < 4)
                Console.WriteLine("You are blessed to have doggos!");
            else
                Console.WriteLine("You may have too many doggos. :(");
        }

        public static void Practice1()
        {
            Console.Write("Enter a number between 1 and 20: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 20)
                Console.WriteLine("Nice!");
            else
                Console.WriteLine("Not Cool. *sad face*");
        }

        public static void Practice2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var min = (number1 < number2) ? number1 : number2;
            Console.WriteLine("Min is: " + min);
        }

        public static void Practice3()
        {
            Console.Write("Enter the width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public static void Practice4()
        {
            Console.Write("Enter speed limit: ");
            var speedlimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of a car: ");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed < speedlimit)
                Console.WriteLine("Your speed is fine.");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (speed - speedlimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("No more driving for you buddy! Gimme your license, stat.");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
        
    }
}
