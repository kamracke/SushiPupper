﻿using Exercises.Loops;
using Exercises.Conditionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var Thing = new PropertiesClass("Daniel", 6);

            Console.WriteLine(Thing.Word);

            Thing.SetWord("");

            Console.WriteLine(Thing.Word);











            //MoreStringsPractice.StringFourTakeTwo();


            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'ok' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Sum of all numbers is: " + sum);
        }
    }
}
