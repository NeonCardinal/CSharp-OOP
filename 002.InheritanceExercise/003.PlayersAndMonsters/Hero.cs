using System;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private int level;
        private string username;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
