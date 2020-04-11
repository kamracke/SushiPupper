using System;

// 3. Write a method that reverses the digits of given decimal number. Example: 256  652

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your number: ");
        string number = Console.ReadLine();

        ReversedNumber(number);
    }

    private static void ReversedNumber(string number)
    {
        char[] reversedNumber = new char[number.Length];

        for (int i = 0; i < number.Length; i++)
        {
            reversedNumber[i] = (char)number[number.Length - i - 1];
        }

        Console.WriteLine("Your reversed number is: {0}", new string(reversedNumber));
    }
}

