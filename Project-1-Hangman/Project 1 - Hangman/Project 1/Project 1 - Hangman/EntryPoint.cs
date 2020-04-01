using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        bool gameOver = false;

        string[] messages = 
            {
            @" __    __       ___      .__   __.   _______ .___  ___.      ___      .__   __.
|  |  |  |     /   \     |  \ |  |  /  _____||   \/   |     /   \     |  \ |  |
|  |__|  |    /  ^  \    |   \|  | |  |  __  |  \  /  |    /  ^  \    |   \|  |
|   __   |   /  /_\  \   |  . `  | |  | |_ | |  |\/|  |   /  /_\  \   |  . `  |
|  |  |  |  /  _____  \  |  |\   | |  |__| | |  |  |  |  /  _____  \  |  |\   |
|__|  |__| /__/     \__\ |__| \__|  \______| |__|  |__| /__/     \__\ |__| \__|",

            @"  _______      ___      .___  ___.  _______      ______   ____    ____  _______ .______       __ 
 /  _____|    /   \     |   \/   | |   ____|    /  __  \  \   \  /   / |   ____||   _  \     |  |
|  |  __     /  ^  \    |  \  /  | |  |__      |  |  |  |  \   \/   /  |  |__   |  |_)  |    |  |
|  | |_ |   /  /_\  \   |  |\/|  | |   __|     |  |  |  |   \      /   |   __|  |      /     |  |
|  |__| |  /  _____  \  |  |  |  | |  |____    |  `--'  |    \    /    |  |____ |  |\  \----.|__|
 \______| /__/     \__\ |__|  |__| |_______|    \______/      \__/     |_______|| _| `._____|(__)",

            @"____    ____  ______    __    __     ____    __    ____  __  .__   __.  __ 
\   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  | |  |
 \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  | |  |
  \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  | |  |
    |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   | |__|
    |__|     \______/   \______/         \__/  \__/     |__| |__| \__| (__)"
        };

        string[] counting = 
            {
            @" __ 
/_ |
 | |
 | |
 | |
 |_|",
            @" ___  
|__ \ 
   ) |
  / / 
 / /_ 
|____|",
            @" ____  
|___ \ 
  __) |
 |__ < 
 ___) |
|____/",
            @" _  _   
| || |  
| || |_ 
|__   _|
   | |  
   |_| ", @" _____ 
| ____|
| |__  
|___ \ 
 ___) |
|____/"
        };

        string ourStartWord = "guess";
        string currentGuessedCharacter = string.Empty;
        string guessedCharactersList = string.Empty;

        char[] maskStartWord = new string('-', ourStartWord.Length).ToCharArray();

        int triesMultiplier = 2;
        int guessingTries = ourStartWord.Length * triesMultiplier;
        int violations = 0;

        Console.CursorVisible = false;

        for (int i = counting.Length; i > 0; i--)
        {
            Console.WriteLine(messages[0]);
            Console.WriteLine(counting[i - 1]);
            Thread.Sleep(100);
            Console.Clear();
        }
        
        while (!gameOver)
        {
            Console.Clear();
            Console.WriteLine("Guess the word: {0}", new string(maskStartWord));
            Console.WriteLine("Guessed characters: {0}", guessedCharactersList);
            Console.WriteLine("You have {0} tries left.", guessingTries);
            Console.WriteLine();
            Console.Write("Your next guess is: ");

            currentGuessedCharacter = Console.ReadLine().ToString();
            guessedCharactersList += currentGuessedCharacter[0] + ", ";

            if (currentGuessedCharacter.Length > 1)
            {
                if (violations >= 1)
                {
                    guessingTries--;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou have to input only ONE single character!");
                Console.WriteLine("You will lose 2 tries for each following violation of the rule!");
                Thread.Sleep(3000);
                Console.ResetColor();

                violations++;
            }

            if (ourStartWord.Contains(currentGuessedCharacter[0].ToString()))
            {
                for (int i = 0; i < ourStartWord.Length; i++)
                {
                    if (ourStartWord[i] == currentGuessedCharacter[0])
                    {
                        maskStartWord[i] = currentGuessedCharacter[0];
                    }
                }
            }

            guessingTries--;

            if (guessingTries == 0)
            {
                gameOver = true;
                Console.WriteLine(messages[1]);
            }
            else if (!new string(maskStartWord).Contains("-"))
            {
                gameOver = true;
                Console.WriteLine(messages[2]);
            }
        }
    }
}