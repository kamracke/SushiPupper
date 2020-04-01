using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class ArraysPractice
    {
        //public static void Arp1()
        //{
        //    int[] array = new int[20];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = i * 5;
        //    }

        //    Console.WriteLine(string.Join(" ", array));
        //}

        //public static void Arp2()
        //{
        //    Console.Write("Please input the first array separated by spaces: ");
        //    string array1 = Console.ReadLine();
        //    string array2;
        //    int[] intarray1 = StringToIntArray(array1);
        //    int[] intarray2 = new int[intarray1.Length];
        //    bool checkArray2Length = true;

        //    while (checkArray2Length)
        //    {
        //        array2 = FillArray2(intarray1, ref intarray2, ref checkArray2Length);
        //    }

        //    Console.Clear();

        //    CheckAndPrint(intarray1, intarray2);
        //}

        //public static void CheckAndPrint(int[] intarray1, int[] intarray2)
        //{
        //    for (int i = 0; i < intarray1.Length; i++)
        //    {
        //        if (intarray1[i] > intarray2[i])
        //        {
        //            Console.WriteLine("Array1[{0}] = {1} is < Array2[{0}] = {2}", i, intarray1[i], intarray2[i]);
        //        }
        //        else if (intarray1[i] < intarray2[i])
        //        {
        //            Console.WriteLine("Array1[{0}] = {1} is < Array2[{0}]) = {2}", i, intarray1[i], intarray2[i]);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Array1[{0}] = {1} is = Array2[{0}] = {2}", i, intarray1[i], intarray2[i]);
        //        }
        //    }
        //}

        //static string FillArray2(int[] intarray1, ref int[] intarray2, ref bool checkArray2Length)
        //{
        //    string array2;
        //    Console.Write("And the second array (must have {0} elements): ", intarray1.Length);

        //    array2 = Console.ReadLine();
        //    intarray2 = StringToIntArray(array2);

        //    if (intarray2.Length > intarray1.Length || intarray2.Length < intarray1.Length)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Your second array needs to contain exactly {0} elements, please try again!", intarray1.Length);
        //        Thread.Sleep(2000);
        //    }
        //    else
        //    {
        //        checkArray2Length = false;
        //    }

        //    return array2;
        //}

        //static int[] StringToIntArray(string array)
        //{

        //    int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

        //    return arrayFromString;

        //}

        //public static void Arp3()
        //{
        //    Console.WriteLine("Input your array of integers (elements!): ");
        //    int[] intArray = StringToIntArray(Console.ReadLine());

        //    int counter = 1;
        //    int currentSequence = 0;
        //    int number = 0;
        //    int i = 1;

        //    for (i = 1; i < intArray.Length; i++)
        //    {
        //        if (intArray[i] != intArray[i-1])
        //        {
        //            if (counter > currentSequence)
        //            {
        //                currentSequence = counter;
        //                number = intArray[i - 1];
        //            }

        //            counter = 1;
        //        }
        //        else if (i == intArray.Length - 1)
        //        {
        //            if (intArray[i] == intArray[i - 1])
        //            {
        //                counter++;

        //                if (counter > currentSequence)
        //                {
        //                    currentSequence = counter;
        //                    number = intArray[i];
        //                }
        //            }
        //        }
        //        else
        //        {
        //            counter++;
        //        }

        //    }

        //    Console.WriteLine("The maximal sequence in this int array is {0} comprised of {1}'s. ", currentSequence, number);
        //}

        //private static int[] StringToIntArray(string array)
        //{
        //    int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

        //    return arrayFromString;
        //}

        //public static void Arp4()
        //{
        //    Console.WriteLine("Input your array of integers separated by spaces: ");
        //    int[] intArray = StringToIntArray(Console.ReadLine());
        //    int[] numbers = new int[intArray.Length];

        //    int counter = 1;
        //    int currentSequence = 0;

        //    for (int i = 1; i < intArray.Length; i++)
        //    {
        //        if (intArray[i] - 1 == intArray[i - 1])
        //        {
        //            counter++;
        //            if (counter > currentSequence)
        //            {
        //                currentSequence = counter;

        //                for (int j = 0; j < counter; j++)
        //                {
        //                    numbers[counter - j - 1] = intArray[i - j];
        //                }
        //            }

        //        }
        //        else
        //        {
        //            counter = 1;
        //        }
        //    }

        //    Console.WriteLine("Max sequence is of {0} integers and they are: ", currentSequence);

        //    foreach (var item in numbers)
        //    {
        //        if (item > 0)
        //        {
        //            Console.Write("{0} ", item);
        //        }
        //    }
        //}

        //private static int[] StringToIntArray(string array)
        //{
        //    int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

        //    return arrayFromString;
        //}

        //public static void Arp5()
        //{
        //    Console.Write("Please provide a number, hereforth known as K: ");
        //    int K = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Please provide a number, hereforth known as N: ");
        //    int N = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Please provide a list of {0} integers, separated by spaces: ", N);

        //    int[] intArray = StringToIntArray(Console.ReadLine());
        //    int[] sumArray = new int[K];

        //    int j = 0;
        //    int highestValIndex = 0;

        //    Console.Write("The int array: ");

        //    foreach (var item in intArray)
        //    {
        //        Console.Write(item + " ");
        //    }

        //    for (int i = 0; i < intArray.Length; i++)
        //    {
        //        highestValIndex = Array.IndexOf(intArray, intArray.Max());

        //        if ((i == highestValIndex) && (j < sumArray.Length))
        //        {
        //            sumArray[j] = intArray[i];
        //            intArray[i] = 0;
        //            j++;
        //            i = 0;
        //        }
        //    }

        //    Console.WriteLine();

        //    Console.Write("The sum array: ");
        //    foreach (var item in sumArray)
        //    {
        //        Console.Write(item + " ");
        //    }

        //    Console.WriteLine();

        //}

        //private static int[] StringToIntArray(string array)
        //{
        //    int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

        //    return arrayFromString;
        //}


        public static void Arp6()
        {
            Console.Write("Please provide some integers separated by spaces: ");
            int[] intArray = StringToIntArray(Console.ReadLine());
            int tempVar;
            int currentMin = 0;

            for (int j = 0; j < intArray.Length; j++)
            {
                currentMin = j;

                for (int i = j; i < intArray.Length; i++)
                {
                    if (intArray[currentMin] > intArray[i])
                    {
                        currentMin = i;
                    }
                }

                tempVar = intArray[j];
                intArray[j] = intArray[currentMin];
                intArray[currentMin] = tempVar;
            }

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }


        private static int[] StringToIntArray(string array)
        {
            int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

            return arrayFromString;
        }
    }
}
