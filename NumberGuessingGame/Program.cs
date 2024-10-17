using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Generates a number between 1 and 100
        int numberOfAttempts = 0;
        bool gameWon = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

        while (!gameWon)
        {
            numberOfAttempts++;
            Console.WriteLine("Enter your guess: ");

            // Handles user input
            string userInput = Console.ReadLine();
            int userGuess;

            // Validate if Input is an integer
            if (int.TryParse(userInput, out userGuess))
            {
                // Step 3: Compare guess to the random number
                if (userGuess == numberToGuess)
                {
                    Console.WriteLine($"Congratulations! You've guessed the number in {numberOfAttempts} attempts. ");
                    gameWon = true;
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number: ");
            }
        }

        // End of the game, offer to restart or quit
        Console.WriteLine("Do you want to play again? (y/n)");
        string playAgain = Console.ReadLine().ToLower();

        if (playAgain == "y")
        {
            Main(args); // Restarts the game
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }

    }
}

