using System;
//Created By Mr.PMJ
namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            const int maxGuesses = 5;
            int remainingGuesses = maxGuesses;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Guess a number between 1 and 100.");

            while (remainingGuesses > 0)
            {
                Console.WriteLine($"You have {remainingGuesses} guesses remaining.");
                Console.Write("Enter your guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    return;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }

                remainingGuesses--;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game over! You ran out of guesses.");
            Console.WriteLine($"The correct number was: {randomNumber}");
            Console.ReadKey();
        }
    }
}