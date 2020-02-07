using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Loops
{
    public static class LoopsPractice
    {

        public static void Kelsey1()
        {
            
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Enter a number between 1 and 5: ");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                if (number >= 1 && number <= 5)
                { 
                    Console.WriteLine("That is correct! You Win!");
                    return;
                }  
                else
                {
                    Console.WriteLine("Nope. Try again.");
                }
                    
            }
          
                Console.WriteLine("Used up all your tries, too bad.");
            

        }

        public static void Practice1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%4 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 4 between 1 and 100.", count);
        }

        public static void Practice2()
        {
            var sum = 0;
            var stayInLoop = true;
            while (stayInLoop)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    stayInLoop = false;
                else
                    sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        public static void Practice3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public static void Practice4()
        {
            var number = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }

                else if (guess < number)
                {
                    Console.WriteLine("Nope, guess higher.");
                }

                else
                {
                    Console.WriteLine("Nope, guess lower.");
                }
            }
            Console.WriteLine("You lost!");
            Console.WriteLine("Secret is " + number);
        }

        public static void Practice5()
        {
            Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var min = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number < min)
                    min = number;
            }
            Console.WriteLine("Min is " + min);
        }
    }
}
