using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            var command = Console.ReadLine().Split(";");

            while (command[0] != "END")
            {
                try
                {
                    if (command[0] == "Team")
                    {
                        Team team = new Team(command[1]);
                        if (!teams.Any(n => n.Name == command[1]))
                        {
                            teams.Add(team);
                        }
                    }

                    if (command[0] == "Add")
                    {
                        if (!teams.Any(n => n.Name == command[1]))
                        {
                            throw new ArgumentException($"Team {command[1]} does not exist.");
                        }

                        Player player = new Player(command[2]);

                        int endurance = int.Parse(command[3]);
                        int sprint = int.Parse(command[4]);
                        int dribble = int.Parse(command[5]);
                        int passing = int.Parse(command[6]);
                        int shooting = int.Parse(command[7]);

                        Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

                        player.Stats = stats;

                        teams.First(n => n.Name == command[1]).AddPlayer(player);
                    }

                    if (command[0] == "Remove")
                    {
                        if (!teams.Any(n => n.Name == command[1]))
                        {
                            throw new ArgumentException($"Team {command[1]} does not exist.");
                        }

                        teams.First(n => n.Name == command[1]).RemovePlayer(command[2]);
                    }

                    if (command[0] == "Rating")
                    {
                        if (!teams.Any(n => n.Name == command[1]))
                        {
                            throw new ArgumentException($"Team {command[1]} does not exist.");
                        }
                        Console.WriteLine(teams.First(n => n.Name == command[1]).ToString());
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine().Split(";");
            }
        }
    }
}