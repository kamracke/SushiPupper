using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearningCSharp
{
    class MoreStringsPractice
    {
        //public static void StringOne()
        //{
        //    Console.Write("Please provide a word: ");
        //    string reversedWord = ReversedString(Console.ReadLine());
        //}

        //private static string ReversedString(string word)
        //{
        //    StringBuilder reversedWord = new StringBuilder();

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        reversedWord.Append(word[i]);
        //    }

        //    return reversedWord.ToString();
        //}

        //public static void StringTwo()
        //{
        //    Console.Write("Provide your expression here: ");
        //    string expression = Console.ReadLine();

        //    int brackets = 0;

        //    for (int i = 0; i < expression.Length && (brackets >=0); i++)
        //    {
        //        if (expression[i] == '(')
        //        {
        //            brackets++;
        //        }
        //        else if (expression[i] == ')')
        //        {
        //            brackets--;
        //        }
        //    }
        //    if (brackets == 0)
        //    {
        //        Console.WriteLine("Correct!");
        //        Thread.Sleep(5000);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong!");
        //        Thread.Sleep(5000);
        //    }
        //}

        //public static void StringThree()
        //{
        //    Console.Write("Please provide a sentence: ");
        //    string text = Console.ReadLine();
        //    Console.Write("Which word do you want to check? : ");
        //    string wordToCheck = Console.ReadLine();

        //    int checkCounter = 0;
        //    int wordCounter = 0;

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == wordToCheck[0])
        //        {
        //            for (int j = 0; j < wordToCheck.Length; j++)
        //            {
        //                if (text[i+j] == wordToCheck[j] && i + j < text.Length)
        //                {
        //                    checkCounter++;
        //                }
        //                else
        //                {
        //                    break;
        //                }

        //                if (checkCounter == wordToCheck.Length)
        //                {
        //                    wordCounter++;
        //                }

        //            }

        //            checkCounter = 0;
        //        }
        //    }

        //    Console.WriteLine("The word {0} is contained {1} time(s) in your sentence.", wordToCheck, wordCounter);
            
        //}

        //public static void StringFour()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string input = "";
        //    bool stringLengthOk = true;

        //    while (stringLengthOk)
        //    {
        //        Console.Write("Please provide a word with no more than 20 characters: ");
        //        input = Console.ReadLine();

        //        if (input.Length > 20)
        //        {
        //            stringLengthOk = true;
        //            Console.WriteLine("Please provide a new word or phrase with a maximum of 20 characters!");
        //            Thread.Sleep(2000);
        //            Console.Clear();
        //        }
        //        else
        //        {
        //            stringLengthOk = false;
        //        }
        //    }

        //    sb.Append(input);

        //    if (input.Length < 20)
        //    {
        //        for (int i = input.Length - 1; i < 20; i++)
        //        {
        //            sb.Append("*");
        //        }
        //    }

        //    Console.WriteLine(sb);
        //}

        //public static void StringFourTakeTwo()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string input = "";
        //    //bool stringLengthOk = true;

        //    Console.Write("Please provide a word or phrase: ");
        //    input = Console.ReadLine();

        //    //while (stringLengthOk)
        //    //{
        //    //    Console.Write("Please provide a word with no more than 20 characters: ");
        //    //    input = Console.ReadLine();

        //    //    if (input.Length > 20)
        //    //    {
        //    //        stringLengthOk = true;
        //    //        Console.WriteLine("Please provide a new word or phrase with a maximum of 20 characters!");
        //    //        Thread.Sleep(2000);
        //    //        Console.Clear();
        //    //    }
        //    //    else
        //    //    {
        //    //        stringLengthOk = false;
        //    //    }
        //    //}

        //    sb.Append(input);

        //    if (input.Length < 20)
        //    {
        //        for (int i = input.Length - 1; i < 20; i++)
        //        {
        //            sb.Append("*");
        //        }
        //        Console.WriteLine(sb);
        //        Thread.Sleep(5000);
        //    }
        //    else
        //    {
        //        sb = sb.SubString(0, 20);
        //        Console.WriteLine(sb);
        //        Thread.Sleep(5000);
        //    }

        //}

        public static void StringFive()
        {
            Console.Write("Please provide your text here: ");
            string text = Console.ReadLine();
            Console.Write("Please provide a word to be checked: ");
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
}
