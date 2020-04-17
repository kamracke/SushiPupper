using System;
using System.Text;
using System.Threading;

// 4. Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

class EntryPoint
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string input = "";
        bool stringLengthOk = true;

        while (stringLengthOk)
        {
            Console.Write("Please input a string with no more than 20 characters: ");
            input = Console.ReadLine();

            if (input.Length > 20)
            {
                stringLengthOk = true;
                Console.WriteLine("Please input a new string with a maximum of 20 characters!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                stringLengthOk = false;
            }
        }

        sb.Append(input);

        if (input.Length < 20)
        {
            for (int i = input.Length - 1; i < 20; i++)
            {
                sb.Append("*");
            }
        }

        Console.WriteLine(sb);
    }
}

