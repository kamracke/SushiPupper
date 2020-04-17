using System;
using System.Text;

// 11. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: “zzzzzaaaarrrriiiiiiiibbbbbbbaaaaa"  “zariba".

class EntryPoint
{
    static void Main(string[] args)
    {
        Console.Write("Input text: ");
        string text = Console.ReadLine();

        StringBuilder newText = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i + 1])
            {
                newText.Append(text[i]);
            }

            if (i == text.Length - 2)
            {
                newText.Append(text[text.Length - 1]);
            }
        }

        Console.WriteLine(newText);
    }
}

