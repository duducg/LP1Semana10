using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    
    public class Controller
    {
        
        private readonly List<Player> playerList;
        private readonly IComparer<Player> compareByName;
        private readonly IComparer<Player> compareByNameReverse;
        private IView v_;
        
    
        public Controller(List<Player> players)
        {
            playerList = players;
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);  
        }

        
        private void Start(IView v_)
        {

            this.v_ = v_;
            int option;
            do
            {
                
                option = v_.ShowMenu();
                switch (option)
                {
                    case 1:
                        
                        InsertPlayer();
                        break;
                    case 2:
                        v_.ListPlayers(playerList);
                        break;
                    case 3:
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case 4:
                        SortPlayerList();
                        break;
                    case 0:
                        v_.EndMessage();
                        break;
                    default:
                        v_.InvalidOption();
                        break;
                }
                v_.AfterMenu();
                
            } while (option != 0);
        }

        private void InsertPlayer()
        {
            //returned instance is passed along
            playerList.Add(v_.InsertPlayer()); 
        }
        private void ListPlayersWithScoreGreaterThan()
        {
            
            int minScore;
            minScore = v_.AskForMinInput();
            
            IEnumerable<Player> playersWithScoreGreaterThan;
 
            playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(minScore);

            
            v_.ListPlayers(playersWithScoreGreaterThan);
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in playerList)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }

        /// <summary>
        ///  Sort player list by the order specified by the user.
        /// </summary>
        private void SortPlayerList()
        {
            PlayerOrder playerOrder;

            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByScore}. Order by score");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByName}. Order by name");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByNameReverse}. Order by name (reverse)");
            Console.WriteLine("");
            Console.Write("> ");

            playerOrder = Enum.Parse<PlayerOrder>(Console.ReadLine());

            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    playerList.Sort();
                    break;
                case PlayerOrder.ByName:
                    playerList.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    playerList.Sort(compareByNameReverse);
                    break;
                default:
                    Console.Error.WriteLine("\n>>> Unknown player order! <<<\n");
                    break;
            }
        }
    }
}
