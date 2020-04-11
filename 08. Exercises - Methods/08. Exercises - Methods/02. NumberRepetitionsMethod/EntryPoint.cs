using System;
using System.Linq;

// 2. Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.


class EntryPoint
{
    static void Main()
    {
        Console.Write("Please input your array: ");
        int[] intArray = StringToIntArray(Console.ReadLine());

        Console.Write("Which element do you want to check? ");
        int element = Convert.ToInt32(Console.ReadLine());

        CheckElementInArray(intArray, element); //takes two arguments, array of type int containing and variable of type int specifying which element we want to check
    }

    static void CheckElementInArray(int[] intArray, int element)
    {
        int counter = 0;

        foreach (var item in intArray)
        {
            if (item == element)
            {
                counter++;
            }
        }

        Console.WriteLine("The element {0} appears {1} times in the array.", element, counter);
    }
    static int[] StringToIntArray(string array)
    {
        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}

