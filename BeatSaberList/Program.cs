using System;

namespace BeatSaberList
{
    class Program
    {
        static void Main(string[] args)
        {
            string morePlayers;
            string list;
            int playerCount = 0;
            string finished;
            int nextPlayer = 0;

            Console.WriteLine("Please Enter The Number of Players Playing Today");
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());
            string[] players = new string[numOfPlayers];
            Console.WriteLine($"{numOfPlayers} are playing today!");
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter The Players Playing Today");
            players[0] = Console.ReadLine();
            playerCount++;
            Console.WriteLine("\n");
            Console.WriteLine($"Player 1 is {players[0]}...");
            AnyMorePlayers();

            void AnyMorePlayers()
            {
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
                Console.WriteLine("Please Enter The Players Playing Today");
                players[playerCount] = Console.ReadLine();
                playerCount++;
                Console.WriteLine("\n");
                Console.WriteLine($"Player {playerCount} is {players[playerCount - 1]}...");
                AnyMorePlayers();
                
            }

            void No()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Do You Want To See A List Of Players?");
                list = Console.ReadLine();

                switch (list)
                {
                    case "Yes":
                        {
                            Console.WriteLine(string.Join(" , ", players));
                            Turn();
                        }
                        break;
                    case "No":
                        {
                            Turn(); 
                        }
                        break;
                }

            }

            void Turn()
            {
                Console.WriteLine("\n");

                Console.WriteLine($"Player {players[nextPlayer]} is up!, Good Luck Gamer");
                Console.WriteLine("\n");

                if (nextPlayer == 0)
                {
                    Console.WriteLine("[WARNING]: Any Answer Other Than Yes (with a capital Y) will end the program!");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Is This Player Finished?");
                finished = Console.ReadLine();

                switch (finished)
                {
                    case "Yes":
                        {
                            if(nextPlayer < numOfPlayers - 1)
                            {
                                nextPlayer++;
                                Turn();
                            }
                            else
                            {
                                EndOfProgram();
                            }
                        }
                        break;
                }
            }

            void EndOfProgram()
            {
                Console.WriteLine("This Program Is Finished, Have Fun Gamers!" + "\n" + "Press Any Key To Close Application" );
                Console.Read();
            }
        }
            
    }
}
