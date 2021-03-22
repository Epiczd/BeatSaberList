using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace BeatSaberListUpdated
{
    class BeatSaberList
    {
        //Just follow the instructions on screen

        //How much time the player has
        static Timer playerTime;

        static bool isTurnOver = false;

        static int time;

        //MainMethod
        static void Main(string[] args)
        {
            //Determines if the player wants to see a list of players
            string list;
            //Displays the current player
            int playerCount = 0;
            //Displays the player who is currently up
            int nextPlayer = 0;

            //Asks for the number of players
            Console.WriteLine("Please Enter The Number of Players Playing Today (Number Only)");

            //Saves the number of players entered into the array
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            //Array containing all players
            string[] players = new string[numOfPlayers];

            //Displays number of players currently playing
            Console.WriteLine($"{numOfPlayers} are playing today!");
            Console.WriteLine("\n");

            /* While the players entered is less than the total number of players,
             * the program will ask the user to enter in the names of the players,
             * and will display each player after being entered
             */
            for (int i = 0; i < numOfPlayers; i++)
            {
                while(i < numOfPlayers)
                {
                    Console.WriteLine($"Please Enter The Name of Player {i + 1}/{numOfPlayers}");

                    players[playerCount] = Console.ReadLine();

                    playerCount++;

                    Console.WriteLine("\n");
                    Console.WriteLine($"Player {playerCount} is {players[playerCount - 1]}");
                    Console.WriteLine("\n");
                    i++;
                }
            }

            Console.WriteLine("How Long do you Want to Play? (Minutes Please!)");

            //How much time each player has
            int timePerTurn = Convert.ToInt32(Console.ReadLine());

            //Converts time to milliseconds
            time = timePerTurn * 60000;
            
            if(timePerTurn == 1)
            {
                Console.Write($"{timePerTurn} Minute Per Turn!");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write($"{timePerTurn} Minutes Per Turn!");
                Console.WriteLine("\n");
            }

            
            //Asks if the user wants to see a list of all players
            Console.WriteLine("Do You Want To See A List Of All Players? (Yes or No)");

            //Records the users response
            list = Console.ReadLine().ToLower();

            /* If the user responds with "Yes", the program will display a list of players,
             * If the user responds with "No", the program will continue on
             */
            if(list == "yes")
            {
                Console.WriteLine("\n");
                Console.WriteLine(string.Join(" , ", players));
            }

            /* While the players being displayed is less that the total number of players,
             * the program display which player currently has a turn,
             * the program will ask if the player's turn is complete,
             * If the user confirms the player's turn is over,
             * the program will move on to the next player,
             * When the program runs through all the players, it will end
             */
            for (int i = 0; i < numOfPlayers; i++)
            {
                while(i < numOfPlayers)
                {
                    Console.WriteLine("\n");

                    Console.WriteLine($"Is Player {players[nextPlayer]} Ready? (Type anything to continue)");

                    Console.ReadLine();

                    //Displays which player get's to play
                    Console.WriteLine($"Player {players[nextPlayer]} is up!, Good Luck Gamer {timePerTurn} minutes Remaning...");
                    Console.WriteLine("\n");

                    SetTimer();
                    while (!isTurnOver)
                    {

                    }

                    isTurnOver = false;
                    nextPlayer++;
                    i++;
     
                }
            }

            Console.WriteLine("\n");
            //Final message before closing the program
            Console.WriteLine("This Program Is Finished, Hope You Had Fun Playing!" + "\n" + "Press Any Key To Close Application");
            Console.Read();
        }

        static void SetTimer()
        {
            playerTime = new Timer(time);
            playerTime.Elapsed += OnTimedEvent;
            playerTime.AutoReset = true;
            playerTime.Enabled = true;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            isTurnOver = true;
        }
    }
}
