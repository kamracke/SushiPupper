using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumOfAllElements
{
    class EntryPoint
    {
        static void Main()
        {
            Console.Write("Input the number of rows of the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Input the number of columns of the array: ");
            int M = int.Parse(Console.ReadLine());

            string array = string.Empty;
            int[] tempRow = new int[0];
            bool correctNumOfElementsInput = false;

            int sum = 0;
            int[,] twoDArray = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                while (!correctNumOfElementsInput)
                {
                    Console.WriteLine("{0} elements are needed.", M);
                    Console.Write("Input the elements of row {0}: ", i);

                    array = Console.ReadLine();
                    tempRow = StringToIntArray(array);

                    if (tempRow.Length == M)
                    {
                        correctNumOfElementsInput = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You must input {0} elements for each of the rows of the array! Try again!", M);
                        Thread.Sleep(1000);
                    }
                }

                for (int j = 0; j < tempRow.Length; j++)
                {
                    twoDArray[i, j] = tempRow[j];
                }

                correctNumOfElementsInput = false;
            }

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    sum += twoDArray[i, j];
                }
            }

            Console.WriteLine("The total sum of all elements in the Two Dimensional array is: {0}", sum);
        }

        public static int[] StringToIntArray(string array)
        {
            int[] arrayFromString = array.Split(' ')
                                         .Select(element => int.Parse(element))
                                         .ToArray();
            return arrayFromString;
        }
    }
}
