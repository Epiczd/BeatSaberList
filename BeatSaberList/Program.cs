using System;

namespace BeatSaberList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = new string[5];
            Console.WriteLine("Please Enter The Players Playing Today");
            players[0] = Console.ReadLine();
            Console.WriteLine($"Player 1 is {players[0]}...");
            Console.WriteLine("Any more players?");
            Console.Read();
        }
            
    }
}
