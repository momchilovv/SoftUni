using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public IReadOnlyCollection<Player> Players => players.AsReadOnly();

        public double Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }
                return players.Average(p => p.Skill());
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!Players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }
            else
            {
                players.Remove(players.First(p => p.Name == playerName));
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Convert.ToInt32(Rating)}";           
        }
    }
}