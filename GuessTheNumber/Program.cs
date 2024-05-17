using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // CONTROLLER
            Random random = new Random();

            // CONTROLLER
            int targetNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            // VIEW
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");

            // CONTROLLER
            // Game loop
            while (!guessedCorrectly)
            {
                // VIEW
                Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                // CONTROLLER

                attempts++;

                if (guess == targetNumber)
                {
                    // VIEW
                    Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {   // VIEW
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {   // VIEW
                    Console.WriteLine("Too high! Try again.");
                }
            }
            // VIEW
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}