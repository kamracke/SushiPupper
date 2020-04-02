using System;
using System.Linq;

// 10. Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


class EntryPoint
{
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; //can also be generated with a loop and unicode from X to Y
        Console.Write("Your word: ");

        string word = Console.ReadLine().ToLower();
        char compare;

        int[] letterIndexes = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            compare = word[i];

            for (int j = 0; j < alphabet.Length; j++)
            {
                if (compare == alphabet[j])
                {
                    letterIndexes[i] = j + 1;
                    break;
                }
            }
        }

        Console.Write("The positions of the letters are: ");

        foreach (var item in letterIndexes)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}

