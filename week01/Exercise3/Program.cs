using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Random object for generating random numbers
        Random randomGenerator = new Random();

        string playAgain = "yes";

        // Outer loop: continues if the user wants to play again
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1; // Initialize with a value not equal to magicNumber
            int guessCount = 0; // Track number of guesses

            Console.WriteLine("\nI'm thinking of a number between 1 and 100...");

            // Inner loop: continue until user guesses the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            // Ask if user wants to play again
            Console.Write("\nDo you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("\nThanks for playing! Goodbye.");
    }
}
