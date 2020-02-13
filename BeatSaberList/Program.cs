using System;

namespace BeatSaberList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = new string[25];
            string morePlayers;
            string list;
            int playerCount = 0;
            Console.WriteLine("Please Enter The Players Playing Today");
            players[0] = Console.ReadLine();
            playerCount++;
            Console.WriteLine($"Player 1 is {players[0]}...");
            AnyMorePlayers();

            void AnyMorePlayers()
            {
                Console.WriteLine("Any more players?");
                morePlayers = Console.ReadLine();

                switch (morePlayers)
                {
                    case "Yes":
                        {
                            Yes();
                        }
                        break;
                    case "No":
                        {
                            No();
                        }
                        break;
                }
            }

            void Yes()
            {
                Console.WriteLine("Please Enter The Players Playing Today");
                players[playerCount] = Console.ReadLine();
                playerCount++;
                Console.WriteLine($"Player {playerCount} is {players[playerCount - 1]}...");
                AnyMorePlayers();
                
            }

            void No()
            {
                Console.WriteLine("Do You Want To See A List Of Players?");
                list = Console.ReadLine();

                switch (list)
                {
                    case "Yes":
                        {
                            Console.WriteLine(players);
                        }
                        break;
                }
            }

            Console.Read();
        }
            
    }
}
