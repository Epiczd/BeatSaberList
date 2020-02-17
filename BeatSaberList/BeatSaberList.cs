﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeatSaberListUpdated
{
    class BeatSaberList
    {
        //Just follow the instructions on screen

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
                    Console.WriteLine("Please Enter The Players Playing Today");

                    players[playerCount] = Console.ReadLine();

                    playerCount++;

                    Console.WriteLine("\n");
                    Console.WriteLine($"Player {playerCount} is {players[playerCount - 1]}");
                    i++;
                }
            }

            Console.WriteLine("\n");
            //Asks if the user wants to see a list of all players
            Console.WriteLine("Do You Want To See A List Of All Players? (Yes or No)");

            //Records the users response
            list = Console.ReadLine();

            /* If the user responds with "Yes", the program will display a list of players,
             * If the user responds with "No", the program will continue on
             */
            switch (list)
            {
                case "Yes":
                    {
                        Console.WriteLine(string.Join(" , ", players));
                    }
                    break;
                case "yes":
                    {
                        Console.WriteLine(string.Join(" , ", players));
                    }
                    break;
                default:
                    {

                    }
                    break;
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
                    //Displays which player get's to play
                    Console.WriteLine($"Player {players[nextPlayer]} is up!, Good Luck Gamer");
                    Console.WriteLine("\n");

                    //Asks if the current player is finished
                    Console.WriteLine("Is This Player Finished? (Type Anything When Finished)");

                    Console.ReadLine();
                    nextPlayer++;
                    i++;
                }
            }

            Console.WriteLine("\n");
            //Final message before closing the program
            Console.WriteLine("This Program Is Finished, Hope You Had Fun Playing!" + "\n" + "Press Any Key To Close Application");
            Console.Read();
        }
    }
}