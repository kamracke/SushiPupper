using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public static class MethodsPractice
    {
        //public static void M1()
        //{
        //    Console.WriteLine("Could I please have your name? ");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Hello, {0}!", name);
        //}

        public static void M2()
        {
            int[] intArray = GetArray();

            CountN(intArray);

        }

        private static int[] GetArray()
        {
            Console.Write("Please provide a list of numbers (integers) separated by spaces: ");
            int[] intArray = StringToIntArray(Console.ReadLine());
            return intArray;
        }

        private static void CountN(int[] intArray)
        {
            Console.Write("Please provide a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int times = 0;

            foreach (var item in intArray)
            {
                if (item == number)
                {
                    times++;
                }
            }

            Console.WriteLine("Your number, {0}, occurs {1} times in your array!", number, times);
        }



        //public static void M3()
        //{
        //    Console.Write("Please provide a number that is 3 digits long or greater: ");
        //    string number = Console.ReadLine();

        //    ReverseNumber(number);
        //}

        //private static void ReverseNumber(string number)
        //{
        //    char[] reversedNumber = new char[number.Length];

        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        reversedNumber[i] = (char)number[number.Length - i - 1];
        //    }

        //    Console.WriteLine("Your reversed number is {0}.", new string(reversedNumber));
        //}


        //public static void M4()
        //{
        //    Calculator(1, 3, 13, 5, 7, 10, 4, 2);
        //}

        //private static void Calculator(params int[] intArray)
        //{
        //    int min = intArray[0];
        //    int max = intArray[0];
        //    int sum = 0;
        //    int product = 1;

        //    for (int i = 0; i < intArray.Length; i++)
        //    {
        //        sum = sum + intArray[i];
        //        product = product * intArray[i];

        //        if (intArray[i] > max)
        //        {
        //            max = intArray[i];
        //        }

        //        if (intArray[i] < min)
        //        {
        //            min = intArray[i];
        //        }

        //    }

        //    Console.WriteLine("The minimum number is {0}", min);
        //    Console.WriteLine("The maximum number is {0}", max);
        //    Console.WriteLine("The sum of the numbers is {0}", sum);
        //    Console.WriteLine("The product of the numbers is {0}", product);

        //}

        private static int[] StringToIntArray(string array)
        {
            int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

            return arrayFromString;
        }


    }
}
