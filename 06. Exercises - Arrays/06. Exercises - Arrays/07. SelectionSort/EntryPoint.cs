using System;
using System.Linq;
// 06. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm. Hint: Search on Google.

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your array: ");
        int[] intArray = StringToIntArray(Console.ReadLine());
        int tempVar;
        int currentMin = 0;

        for (int j = 0; j < intArray.Length; j++)
        {
            currentMin = j;                     //initial current min changes everytime

            for (int i = j; i < intArray.Length; i++)
            {
                if (intArray[currentMin] > intArray[i])
                {
                    currentMin = i;             //save the current min number position
                }
            }

            tempVar = intArray[j];              //save the first element of the array (subarray) in temporary variable
            intArray[j] = intArray[currentMin]; //set the first element of the array (subarray) to the current minimum variable
            intArray[currentMin] = tempVar;     //set the element at the old position of the current minimum equal to the saved first element
        }

        foreach (var item in intArray)
        {
            Console.WriteLine(item);
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

