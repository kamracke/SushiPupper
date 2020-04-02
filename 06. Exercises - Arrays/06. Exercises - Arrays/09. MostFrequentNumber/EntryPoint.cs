using System;
using System.Linq;

// 07. Write a program that finds the most frequent number in an array. 
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

//Sort then count...
class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your array: ");
        string array = Console.ReadLine();
        int[] intArray = StringToIntArray(array);

        ArraySort(intArray);

        int theValue = 0;
        int occurance = 0;
        int tempOccurance = 1;

        for (int i = 0; i < intArray.Length - 1; i++)
        {
            if (intArray[i] == intArray[i + 1])
            {
                tempOccurance++;
            }
            else
            {
                tempOccurance = 1;
            }
            if (tempOccurance > occurance)
            {
                occurance = tempOccurance;
                theValue = intArray[i];
            }
        }

        Console.WriteLine(theValue);
        Console.WriteLine(occurance);
    }

    private static void ArraySort(int[] intArray)
    {
        int tempVar;
        int currentMin = 0;

        for (int j = 0; j < intArray.Length; j++)
        {
            currentMin = j;                                 //initial current min changes everytime
            for (int i = j; i < intArray.Length; i++)
            {
                if (intArray[currentMin] > intArray[i])
                {
                    currentMin = i;             //save the current min number position
                }
            }
            tempVar = intArray[j];             //save the first element of the array (subarray) in temporary variable
            intArray[j] = intArray[currentMin]; //set the first element of the array (subarray) to the current minimum variable
            intArray[currentMin] = tempVar;    //set the element at the old position of the current minimum equal to the saved first element
        }
    }

    public static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}

