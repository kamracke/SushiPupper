using System;

// 3. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your text: ");
        string text = Console.ReadLine();
        Console.Write("Which word do you want to check: ");
        string wordToCheck = Console.ReadLine();

        int checkCounter = 0;
        int wordCounter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == wordToCheck[0])
            {
                for (int j = 0; j < wordToCheck.Length; j++)
                {
                        if (text[i + j] == wordToCheck[j] && i + j < text.Length)
                        {
                            checkCounter++;
                        }
                        else
                        {
                            break;
                        }

                        if (checkCounter == wordToCheck.Length)
                        {
                            wordCounter++;
                        }
                }

                checkCounter = 0;
            }
        }

        Console.WriteLine("The word {0} is contained {1} times in the given text.", wordToCheck, wordCounter);
    }
}