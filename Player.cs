using System;

namespace SoccerApp
{
    class Player
    {
        protected string Firstname;
        protected string Lastname;
        protected string roles;

        public Player()
        {
            this.firstname = Firstname;
            this.lastname = Lastname;
            this.role = roles;
        }

        public string firstname
        {
            get { return Firstname; }
            set { Firstname = value; }
        }
        public string lastname
        {
            get { return Lastname; }
            set { Lastname = value; }
        }
        public string role
        {
            get { return roles; }
            set { roles = value; }
        }


        public enum Roles
        {
            GK = 1,
            RB = 2,
            LB = 3,
            CB = 4,
            RW = 7,
            CF = 9,
            MF = 10,
            LW = 11
        }
    }
}
