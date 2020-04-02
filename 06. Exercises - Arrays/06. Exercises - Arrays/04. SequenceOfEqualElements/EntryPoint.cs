using System;
using System.Linq;

// 03. Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Input your array of integers ( elements!): ");
        int[] intArray = StringToIntArray(Console.ReadLine());

        int counter = 1;
        int currentSequence = 0;
        int number = 0;
        int i = 1;

        for (i = 1; i < intArray.Length; i++) 
        {
            if (intArray[i] != intArray[i - 1])   //check if current and previous element are different
            {
                if (counter > currentSequence)
                {
                    currentSequence = counter;
                    number = intArray[i-1];
                }

                counter = 1;
            }
            else if (i == intArray.Length - 1)     //check we have reached the end of the array
            {
                if (intArray[i] == intArray[i - 1]) //check if the last and previous elements are equal
                {
                    counter++;

                    if (counter > currentSequence)
                    {
                        currentSequence = counter;
                        number = intArray[i];
                    }
                }
            }
            else
            {
                counter++;                          //increase counter if we are in a sequence
            }
        
        }

        Console.WriteLine("The maximal sequence in this int array is {0} comprised of {1}'s. ", currentSequence, number);
    }

    private static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}

