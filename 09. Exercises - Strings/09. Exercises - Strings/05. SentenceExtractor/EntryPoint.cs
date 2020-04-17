using System;

// 5. Write a program that extracts from a given text all sentences containing given word.

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your text here: ");
        string text = Console.ReadLine();
        Console.Write("Input a word to be checked: ");
        string word = Console.ReadLine();

        int dots = 0;

        foreach (var item in text)
        {
            if (item == '.')
            {
                dots++;
            }
        }

        string[] extractedSentences = new string[dots];
        string tempString = "";
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            tempString = tempString + text[i];

            if (text[i] == '.')
            {
                extractedSentences[counter] = tempString;
                counter++;
                tempString = "";
            }
        }

        string[] checkedSentences = new string[dots];

        for (int i = 0; i < extractedSentences.Length; i++)
        {
            if (extractedSentences[i].Contains(word))
            {
                Console.WriteLine(extractedSentences[i]);
            }
        }
    }
}

