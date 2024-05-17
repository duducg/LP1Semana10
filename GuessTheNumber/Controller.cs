using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private IView view;
        public void Start(IView view)
        {
            
            Random random = new Random();
            this.view = view;
            int targetNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            
            view.WelcomePlayer();
            
            while (!guessedCorrectly)
            {
                
                guess = view.GuessNumber();               
                

                attempts++;

                if (guess == targetNumber)
                {
                    // VIEW
                    view.GuessCorrect(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {   // VIEW
                    view.GuessLow();
                }
                else
                {   // VIEW
                    view.GuessHigh();
                }
            }
            // VIEW
            view.GoodBye();
        }
    }
}