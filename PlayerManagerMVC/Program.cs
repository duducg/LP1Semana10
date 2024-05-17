using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create a new instance of the player listing program
            List<Player> playerList = new List<Player>()
            {
                new Player("Gualter",100),
                new Player("Almondega",500),
            };
            Controller controller = new Controller();
            IView v_ = new UglyView(controller, playerList);
            controller.Start(v_);
        }
    }
}