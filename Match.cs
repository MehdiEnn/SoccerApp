using System;

namespace SoccerApp
{
    class Match
    {
        public int Score { get; set; }
        protected List<string> Team1 = new List<string>();
        protected List<string> Team2 = new List<string>();

        public List<string> team1
        {
            get { return Team1; }
            set { Team1 = value; }
        }
        public List<string> team2
        {
            get { return Team2; }
            set { Team2 = value; }
        }

        public Match()
        {
            Team team = new Team();

            Random random = new Random();
            team.playerlist = team.playerlist.OrderBy(e => random.Next()).ToList();
            
            for (int i = 0; i < 5; i++)
            {
                team1.Add(team.playerlist[i]);
            }
            for (int i = 5; i < 10; i++)
            {
                team2.Add(team.playerlist[i]);
            }
        }
    }
}
