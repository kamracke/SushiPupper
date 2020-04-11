using System;

// 1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

class EntryPoint
{
    static void Main()
    {
        PrintName();
    }

    private static void PrintName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Hello, {0}!", name);
    }
}

