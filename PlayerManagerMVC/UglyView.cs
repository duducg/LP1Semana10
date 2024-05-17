using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class UglyView:IView
    {
        public int ShowMenu()
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
            Console.Write("\nMinimum score player should have? ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");
            // Show each player in the enumerable object
            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

    }
}