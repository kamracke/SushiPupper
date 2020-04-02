using System;

// 1. Write a program that prints the following matrices with n rows and n columns for a given number n: All examples are for n=4.

class EntryPoint
{
    static void Main()
    {
        int N = 4;
        int[,] matrixA = new int[N, N];
        int numbers = 1;

        int beginningRow = N - 1;
        int beginningCol = 0;
        int counter = 0;
        int currentValue = 1;
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                matrixA[j, i] = numbers;
                numbers++;
            }
        }

        numbers = 1;
        PrintMatrix(matrixA);

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[j, i] = numbers;
                    numbers++;
                }
            }
            else
            {
                for (int j = matrixA.GetLength(1) - 1 ; j >= 0; j--)
                {
                    matrixA[j, i] = numbers;
                    numbers++;
                }
            }
        }

        numbers = 1;

        Console.WriteLine();

        PrintMatrix(matrixA);
        
        while (currentValue <= N * N)
        {
            currentRow = beginningRow + counter;
            currentCol = beginningCol + counter;
            matrixA[currentRow, currentCol] = currentValue;
            counter++;
            currentValue++;

            if (beginningRow > 0)
            {
                if (currentRow == N - 1) 
                {
                    beginningRow--;
                    counter = 0;
                }
            }
            else
            {
                if (currentCol == N - 1) 
                {
                    beginningCol++;
                    counter = 0;
                }
            }
        }

        Console.WriteLine();
        PrintMatrix(matrixA);
    }

    private static void PrintMatrix(int[,] matrixA)
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                Console.Write("{0} ",matrixA[i, j]);
            }

            Console.WriteLine();
        }
    }
}

