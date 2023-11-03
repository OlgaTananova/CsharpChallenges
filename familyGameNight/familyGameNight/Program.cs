using System;
using System.Collections.Generic;
using System.Linq;

namespace gamenight
{
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Harrison", "Ferrone", 233, 198),
            new Player("Alex", "Ferrone", 219, 202),
            new Player("Haley", "Ferrone", 241, 222),
            new Player("John", "Doe", 144, 198),
            new Player("Sally", "Doe", 233, 198),
            new Player("Frank", "Smith", 189, 234),
            new Player("Joan", "Smith", 211, 178)
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
            var targetImprovement = int.Parse(Console.ReadLine());

            // MARK: Result
            PrintStats(targetImprovement);
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void PrintStats(int targetImprovement)
        {
            var improvedPlayers = from p in players
                                  where (p.currentScore - p.lastScore) >= targetImprovement
                                  select p into pl
                                  group pl by pl.firstname.Substring(0,1);
                               
           foreach (var player in improvedPlayers.ToList()) {

                Console.WriteLine(player.Key.ToString());
                foreach (var pl in player){
                    Console.WriteLine($"{pl.firstname} {pl.lastname} improved by {(pl.currentScore - pl.lastScore)} points!");
                }
            }
                                  
        }
    }
}