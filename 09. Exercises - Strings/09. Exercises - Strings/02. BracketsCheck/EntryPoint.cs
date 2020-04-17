using System;

// 2. Write a program to check if in a given expression the brackets are put correctly. Correct:((x-y)/(10-z)). Incorrect:  )(x*y)-1).

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input your expression here: ");
        string expression = Console.ReadLine();

        int brackets = 0;

        for (int i = 0; i < expression.Length && (brackets >= 0); i++)
        {
            if (expression[i] == '(')
            {
                brackets++;
            }
            else if (expression[i] == ')')
            {
                brackets--;
            }

        }

        if (brackets == 0)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
}
