using System;
using System.Collections.Generic;

// 10. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your text: ");
        string[] text = Console.ReadLine().Split(new string[] { " ", ", " }, StringSplitOptions.None);
        string tempString = "";

        int[] wordsRepetition = new int[text.Length];

        Array.Sort(text);

        List<string> extractedWords = new List<string>();
        List<int> extractedRepCounts = new List<int>();

        for (int i = 0; i < text.Length; i++)
        {
            tempString = text[i];

            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == tempString)
                {
                    wordsRepetition[i]++;
                }
            }
        }

        extractedWords.Add(text[0]);
        extractedRepCounts.Add(wordsRepetition[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                extractedWords.Add(text[i]);
                extractedRepCounts.Add(wordsRepetition[i]);
            }
        }

        for (int i = 0; i < extractedWords.Count; i++)
        {
            Console.WriteLine("The word \"{0}\" is contained {1} times.", extractedWords[i], extractedRepCounts[i]);
        }
    }
}
