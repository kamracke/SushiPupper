using System;
using System.Linq;

// 04. Write a program that finds the maximal increasing sequence in an array. 
// Example:  {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Input your array of integers (elements!): ");
        int[] intArray = StringToIntArray(Console.ReadLine());
        int[] numbers = new int[intArray.Length];

        int counter = 1;
        int currentSequence = 0;

        for (int i = 1; i < intArray.Length; i++)
        {
            if (intArray[i] - 1 == intArray[i - 1])    //if the current element - 1 is equal to the previous element
            {
                counter++;
                if (counter > currentSequence)        //if counter is higher than the current max sequence
                {
                    currentSequence = counter;

                    for (int j = 0; j < counter; j++)
                    {
                        numbers[counter - j - 1] = intArray[i - j]; //fill the current sequence from right to left
                    }
                }

            }
            else
            {
                counter = 1;                  //if the sequence is broken reset counter
            }

        }

        Console.WriteLine("Max sequnce is of {0} elements and they are: ", numbers.Length);

        foreach (var item in numbers)
        {
            Console.Write("{0} ", item);

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

