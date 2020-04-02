using System;
using System.Linq;

// 09. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your array (your array must be sorted, if its not, it will get sorted automatically): ");
        int[] intArray = StringToIntArray(Console.ReadLine());

        Console.Write("The index of what element are you trying to find: ");
        int lookFor = Convert.ToInt32(Console.ReadLine());

        Array.Sort(intArray);

        BinSearch(intArray, 0, intArray.Length, lookFor);

    }

    static void BinSearch(int[] intArray, int startIndex, int endIndex, int lookFor)
    {
        if(endIndex <= startIndex)
        {
            Console.WriteLine("Not Found!");
            return;
        }
        else
        {
            int middle = startIndex + (endIndex - startIndex) / 2;
            if (lookFor < intArray[middle])
            {
                BinSearch(intArray, startIndex, middle - 1, lookFor);
            }
            else if (lookFor > intArray[middle])
            {
                BinSearch(intArray, middle + 1, endIndex, lookFor);
            }
            else
            {
                Console.WriteLine("{0} is at position {1} counting from 0.", lookFor, middle);
                return;
            }
        }
    }

    static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}
