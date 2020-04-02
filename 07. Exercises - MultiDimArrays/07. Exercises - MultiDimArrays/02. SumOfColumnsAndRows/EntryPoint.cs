using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumOfColumnsAndRows
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

            int[] rowsSums = new int[N];
            int[] columnsSums = new int[M];
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

            for (int i = 0; i < rowsSums.Length; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    rowsSums[i] += twoDArray[i, j];
                }
            }

            for (int i = 0; i < columnsSums.Length; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    columnsSums[i] += twoDArray[j, i];
                }
            }

            for (int i = 0; i < rowsSums.Length; i++)
            {
                Console.WriteLine("The sum of the {0} row is: {1}", i, rowsSums[i]);
            }

            for (int i = 0; i < columnsSums.Length; i++)
            {
                Console.WriteLine("The sum of the {0} column is: {1}", i, columnsSums[i]);
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
}
