using System;
using System.Linq;
using System.Threading;

// 2. Write a program that reads two arrays from the console and compares them element by element.

class EntryPoint
{
    static void Main()
    {
        Console.Write("Please input the first array separated by spaces: ");
        string array1 = Console.ReadLine();
        string array2;
        int[] intarray1 = StringToIntArray(array1);
        int[] intarray2 = new int[intarray1.Length];
        bool checkArray2Length = true;

        while (checkArray2Length)
        {
            array2 = FillArray2(intarray1, ref intarray2, ref checkArray2Length);
        }

        Console.Clear();

        CheckAndPrint(intarray1, intarray2);
    }

    static void CheckAndPrint(int[] intarray1, int[] intarray2)
    {
        for (int i = 0; i < intarray1.Length; i++)
        {
            if (intarray1[i] > intarray2[i])
            {
                Console.WriteLine("Array1[{0}] = {1} is > than Array2[{0}] = {2}", i, intarray1[i], intarray2[i]);
            }
            else if (intarray1[i] < intarray2[i])
            {
                Console.WriteLine("Array1[{0}] = {1} is < than Array2[{0}] = {2}", i, intarray1[i], intarray2[i]);
            }
            else
            {
                Console.WriteLine("Array1[{0}] = {1} is = to Array2[{0}] = {2}", i, intarray1[i], intarray2[i]);
            }
        }
    }

    static string FillArray2(int[] intarray1, ref int[] intarray2, ref bool checkArray2Length)
    {
        string array2;
        Console.Write("And the second array (must have {0} elements): ", intarray1.Length);

        array2 = Console.ReadLine();
        intarray2 = StringToIntArray(array2);

        if (intarray2.Length > intarray1.Length || intarray2.Length < intarray1.Length)
        {
            Console.Clear();
            Console.WriteLine("Your second array needs to contain exactly {0} elements, please try again!", intarray1.Length);
            Thread.Sleep(2000);
        }
        else
        {
            checkArray2Length = false;
        }

        return array2;
    }

    static int[] StringToIntArray(string array)
    {

        int[] arrayFromString = array.Split(' ')
                                     .Select(element => int.Parse(element))
                                     .ToArray();
        return arrayFromString;
    }
}

