using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View:IView
    {
        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");


        }
        public int GuessNumber ()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void GuessCorrect(int attempts)
        {
            Console.WriteLine(
            "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }
        public void GuessLow()
        {
            Console.WriteLine("Too low! Try again.");
        }
        public void GuessHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }
        public void GoodBye()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

        
    }
    
}