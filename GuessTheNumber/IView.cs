using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomePlayer();
        int GuessNumber();
        void GuessCorrect(int attempts);
        void GuessLow();
        void GuessHigh();
        void GoodBye();
    }
}