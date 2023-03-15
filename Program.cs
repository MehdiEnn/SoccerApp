// app backend pour organisation des matches de foot
// 2 teams with 5/6 spots each
// user can give all names, teams split is random
// we can keep track on the score
// gives the winner when user marks the game ended

// add api to web scrape for available soccer pitches nearby
// 

using System;

namespace SoccerApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Soccer Application. \n\nPlease enter the players' names :\n");
            
            Match match = new Match();

            Console.WriteLine();

            Console.WriteLine("The first team's players :");

            foreach (string name in match.team1) 
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("The second team's players :");

            foreach (string name in match.team2)
            {
                Console.WriteLine(name);
            }
        }
    }
}






