using System;
using static SoccerApp.Player;

namespace SoccerApp
{
    class Team
    {
        protected List<string> PlayerList = new List<string>();

        public List<string> playerlist
        {
            get { return PlayerList; }
            set { PlayerList = value; }
        }

        public int Playernumbers;
        public Team()
        {
            this.PlayerList = playerlist;

            while (Playernumbers < 6)
            {
                Player player = new Player();
                Console.Write("Player " + Convert.ToInt16(Playernumbers+ 1) + " firstname : ");
                player.firstname = Console.ReadLine();
                Console.Write("Player " + Convert.ToInt16(Playernumbers + 1) + " lastname : ");
                player.lastname = Console.ReadLine();
                Console.Write("Player " + Convert.ToInt16(Playernumbers + 1) + " role : ");
                Roles roles = (Roles)Enum.Parse(typeof(Roles), Console.ReadLine());
                player.role = roles.ToString();
                playerlist.Add((player.firstname + " " + player.lastname + " " + player.role).ToString());
                Playernumbers++;
            }
        }
    }
}
