using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = false;

        do
        {
            Console.WriteLine("Welcome to Guess the Number game, where you have to guess the magic number! Good luck... ");

            Random randomNumGen = new Random();
            int magicNum = randomNumGen.Next(1, 101);

            bool guessLoop = true;
            
            do 
            {
                Console.Write("What is your guess? ");
            int guessNum = int.Parse(Console.ReadLine());

            if (magicNum < guessNum)
            {
                Console.WriteLine("Lower...");

            }
            else if (magicNum > guessNum)
            {
                Console.WriteLine("Higher...");
            }
            else
            {
                Console.WriteLine("You guessed it! You won!");
                guessLoop = false;

                Console.WriteLine("Do you want to play again? (yes/no) ");
                string again = Console.ReadLine();
                if (again == "yes")
                {
                    playAgain = true;
                }
                else {
                    Console.WriteLine("Thank you for playing! See you later!");
                    playAgain = false;
                }
                
            }

            }
            while (guessLoop);
        }
        while (playAgain);
    }
}