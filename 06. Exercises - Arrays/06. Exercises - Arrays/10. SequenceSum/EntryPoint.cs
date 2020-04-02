using System;
using System.Linq;

// 08. Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11 => {4, 2, 5}

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your array: ");
        int[] intArray = StringToIntArray(Console.ReadLine());

        Console.Write("Find subarray with sum equal to: ");
        int S = Convert.ToInt32(Console.ReadLine());

        int startIndex, endIndex, sum;
        startIndex = endIndex = sum = 0;

        bool solved = false;

        for (int i = 0; i < intArray.Length; i++)
        {
            if (solved == false)
            {
                for (int j = i; j < intArray.Length; j++)
                {
                    endIndex = j;
                    sum = sum + intArray[j];

                    if (sum == S)
                    {
                        solved = true;
                        break;
                    }
                }    
            }
            else
            {
                break;
            } 

            sum = 0;
            startIndex = i;
        }

        Console.WriteLine("The sum is between elements {0} and {1}.", startIndex, endIndex);

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", intArray[i]);
        }
    }
    private static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}
