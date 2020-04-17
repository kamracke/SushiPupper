using System;
using System.Text;

// 1. Write a program that reads a string, reverses it and prints the result at the console. Do NOT use any built in methods!

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input a word: ");
        string reversedWord = ReversedString(Console.ReadLine());

        Console.WriteLine(reversedWord);
    }

    private static string ReversedString(string word)
    {
        StringBuilder reversedWord = new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }

        return reversedWord.ToString();
    }
}

