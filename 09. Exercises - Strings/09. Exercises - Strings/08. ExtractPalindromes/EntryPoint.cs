using System;
using System.Text;

// 8. Write a program that extracts from a given text all palindromes, e.g. “level", “stats", “radar".

class EntryPoint
{
    static void Main()
    {
        StringBuilder palindromes = new StringBuilder();

        Console.Write("Input your sentence: ");
        string text = Console.ReadLine();
        string[] extractedWords = text.Split(' ');

        int counter = 0;

        bool isPalindrome = false;

        foreach (var item in extractedWords)
        {
            isPalindrome = IsPalindrome(isPalindrome, item);

            if (isPalindrome == true)
            {
                palindromes.Append(item);

                if (counter != extractedWords.Length - 1)
                {
                    palindromes.Append(", ");
                }
            }
            counter++;
        }

        Console.WriteLine(palindromes);
    }

    private static bool IsPalindrome(bool isPalindrome, string item)
    {
        for (int i = 0; i < item.Length / 2; i++)
        {
            if (item[i] == item[item.Length - i - 1])
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}

