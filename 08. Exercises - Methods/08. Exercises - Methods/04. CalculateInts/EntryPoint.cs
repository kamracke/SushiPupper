using System;
using System.Linq;
// 4. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

class EntryPoint
{
    static void Main()
    {
        MinMaxSumProduct(1, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6); // write as many integers as you want, separated by a comma
    }

    private static void MinMaxSumProduct(params int[] intArray)
    {
        int min = intArray[0];
        int max = intArray[0];
        int sum = 0;
        int product = 1;

        for (int i = 0; i < intArray.Length; i++)
        {
            sum = sum + intArray[i];
            product = product * intArray[i];

            if (intArray[i] > max)
            {
                max = intArray[i];
            }

            if (intArray[i] < min)
            {
                min = intArray[i];
            }
        }

        Console.WriteLine("min: {0}, max: {1}, sum: {2}, product: {3}", min, max, sum, product);
    }

    private static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}

