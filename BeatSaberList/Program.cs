using System;

namespace BeatSaberList
{
    class Program
    {
        //No Code, just instructions (Collapse This if you don't need it open)
        void Instructions()
        {
            /* Instructions are pretty simple, just respond to any questions asked by the program.
             * If you are prompted with a "Yes or No" question, please only respond with either,
             * Capital Y Yes, or Capital N No, if it is anything else, or not captial, the program will break.
             */
        }
        static void Main(string[] args)
        {
            //Asks if more players are playing
            string morePlayers;
            //Asks if the player wants to see a list of players
            string list;
            //Determines which player is in what spot
            int playerCount = 0;
            //Determines if a player is finished playing or not
            string finished;
            //The Next Player in the queue
            int nextPlayer = 0;

            //OnStart, the application will ask how many people are playing
            Console.WriteLine("Please Enter The Number of Players Playing Today");
            //Total amount of players
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            //Array containg all players
            string[] players = new string[numOfPlayers];

            //Says how many players are playing
            Console.WriteLine($"{numOfPlayers} are playing today!");
            Console.WriteLine("\n");

            //Asks for the name of players
            Console.WriteLine("Please Enter The Players Playing Today");
            //Reads the players name, and stores it in the array
            players[0] = Console.ReadLine();
            //Increases the player count so the correct player is displayed
            playerCount++;
            Console.WriteLine("\n");
            //Displays the name of player 1
            Console.WriteLine($"Player 1 is {players[0]}...");
            AnyMorePlayers();

            //Asks if there are any more players
            void AnyMorePlayers()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Any more players? (Yes or No)");
                //Determines if there are more players or not
                morePlayers = Console.ReadLine();

                /* If there are more players to enter, the program will continue to ask for them.
                 * If there are no more players to enter, the program will move on to the next step
                 */
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

            //If the user responded yes to more players
            void Yes()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please Enter The Players Playing Today");
                //Reads the players name, then stores it in the array
                players[playerCount] = Console.ReadLine();
                //Increases the player count so the correct player is displayed
                playerCount++;
                Console.WriteLine("\n");
                //Displays the name of the player just entered
                Console.WriteLine($"Player {playerCount} is {players[playerCount - 1]}...");
                AnyMorePlayers();
                
            }

            //If the user responded no to more players
            void No()
            {
                Console.WriteLine("\n");
                //Asks if they want to see a list of all players
                Console.WriteLine("Do You Want To See A List Of Players? (Yes or No)");
                //Records the response
                list = Console.ReadLine();

                /* If the user responded with yes, it will display a list of the players.
                 * If the user responded with no, the program will move on to the next step
                 */
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

            //Manages each players turn
            void Turn()
            {
                Console.WriteLine("\n");
                //Displays which player get's to play
                Console.WriteLine($"Player {players[nextPlayer]} is up!, Good Luck Gamer");
                Console.WriteLine("\n");

                //Appears the first time to warn the user about the next question's response
                if (nextPlayer == 0)
                {
                    Console.WriteLine("[WARNING]: Any Answer Other Than Yes (with a capital Y) will end the program!");
                    Console.WriteLine("\n");
                }

                //Asks if the current player's turn has ended
                Console.WriteLine("Is This Player Finished? (Yes Only When The Player Is Done)");
                //Records the users response
                finished = Console.ReadLine();

                /* When the user says yes, the TurnManager will display the next player.
                 * If all players have finished, the program will end
                 */
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

            //The End Of The Program
            void EndOfProgram()
            {
                Console.WriteLine("\n");
                Console.WriteLine("This Program Is Finished, Hope You Had Fun Playing!" + "\n" + "Press Any Key To Close Application" );
                Console.Read();
            }
        }
            
    }
}
