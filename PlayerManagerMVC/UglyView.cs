using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class UglyView:IView
    {
        public int MainMenu()
        {
            return 0;

        }
        public void EndMessage()
        {

        }
        public void InvalidOption()
        {

        }
        public void AfterMenu()
        {

        }
        public Player InsertPlayer()
        {
            return new Player("Cum", 10);
        }
        public int AskForMinInput()
        {
            return 0;
        }
    }
}