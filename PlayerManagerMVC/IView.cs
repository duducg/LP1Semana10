using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public interface IView
    {
        int ShowMenu();
        void EndMessage();
        void InvalidOption();
        void AfterMenu();
        Player InsertPlayer();
        int AskForMinInput();
        void ListPlayers(IEnumerable<Player> playersToList);
    }
}