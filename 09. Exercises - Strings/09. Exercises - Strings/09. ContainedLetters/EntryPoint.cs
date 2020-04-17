using System;
using System.Linq;

// 9. Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input some text: ");
        string text = Console.ReadLine();

        char[] containedChars = new char[text.Length];

        int[] charRepetitions = new int[text.Length];
        int charsCounter = 0;

        for (int i = 0; i < charRepetitions.Length; i++)
        {
            charRepetitions[i] = 1;
        }
        
        for (int i = 0; i < text.Length; i++)
        {
            if (containedChars.Contains(text[i]) == false && text[i] != ' ')
            {
                containedChars[charsCounter] = text[i];
                charsCounter++;
            }
            else if (containedChars.Contains(text[i]) == true)
            {
                charRepetitions[Array.IndexOf(containedChars, text[i])]++;
            }
        }
        
        for (int i = 0; i < charsCounter; i++)
        {
            Console.WriteLine("{0} is contained {1} times", containedChars[i], charRepetitions[i]);
        }

        Console.WriteLine();
    }
}

