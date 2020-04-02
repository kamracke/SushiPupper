using System;
using System.Linq;

// 05. Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

class EntryPoint
{
    static void Main(string[] args)
    {
        Console.Write("Input K: ");
        int K = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input an array of {0} elements: ", N);

        int[] intArray = StringToIntArray(Console.ReadLine());
        int[] sumArray = new int[K];

        int j = 0;
        int highestValIndex = 0;

        Console.Write("The int array: ");

        foreach (var item in intArray)
        {
            Console.Write(item + " ");
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            highestValIndex = Array.IndexOf(intArray, intArray.Max());

            if ((i == highestValIndex) && (j < sumArray.Length))
            {
                sumArray[j] = intArray[i];
                intArray[i] = 0;
                j++;
                i = 0;
            }
        }
        
        Console.WriteLine();

        Console.Write("The sum array: ");
        foreach (var item in sumArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        
    }

    static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}
