using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CreateSoccerTeam
{
    class Team
    {
        private List<Player> players;
        private string name;
        private int rating;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating
        {
            get { return rating; }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.players.Any(p => p.Name == playerName))
            {
                Player player = this.players.Find(p => p.Name == playerName);
                this.players.Remove(player);
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
        }

        public void CalculateRating()
        {
            this.rating = this.players.Sum(p => p.SkillLevel);
        }
    }
}
