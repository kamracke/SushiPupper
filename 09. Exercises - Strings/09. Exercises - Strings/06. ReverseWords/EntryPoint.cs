using System;
using System.Text;

// 6. Write a program that reverses the words in given sentence.

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your sentence: ");
        string sentence = Console.ReadLine();

        StringBuilder tempString = new StringBuilder();
        StringBuilder reversedWord = new StringBuilder();
        StringBuilder reversedSentence = new StringBuilder();

        string[] extractedWords = sentence.Split(' ');

        for (int i = 0; i < extractedWords.Length; i++)
        {
            tempString.Append(extractedWords[i]);

            for (int j = extractedWords[i].Length - 1; j > -1; j--)
            {
                reversedWord.Append(tempString[j]);
            }

            reversedSentence.Append(reversedWord);

            if (i != extractedWords.Length - 1)
            {
                reversedSentence.Append(" ");
            }

            reversedWord.Clear();
            tempString.Clear();
        }
        Console.WriteLine(reversedSentence);
    }
}
