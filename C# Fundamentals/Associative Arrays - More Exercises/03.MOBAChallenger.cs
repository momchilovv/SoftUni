using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, int> totalSkill = new Dictionary<string, int>();

        string[] splitters = { " -> ", " vs " };

        string rawInput = Console.ReadLine();
        string[] input = rawInput.Split(splitters, StringSplitOptions.None);

        while (input[0] != "Season end")
        {
            if (rawInput.Contains(" -> "))
            {
                string playerName = input[0], position = input[1];
                int skill = int.Parse(input[2]);

                if (!totalSkill.ContainsKey(playerName))
                {
                    totalSkill.Add(playerName, 0);
                }
                if (!players.ContainsKey(playerName))
                {
                    var temp = new Dictionary<string, int>();
                    temp.Add(position, skill);
                    players.Add(playerName, temp);
                }
                else if (!players[playerName].ContainsKey(position))
                {
                    players[playerName].Add(position, skill);
                }

                if (players[playerName][position] < skill)
                {
                    players[playerName][position] = skill;
                }
            }

            else if (rawInput.Contains(" vs "))
            {
                string firstPlayer = input[0], secondPlayer = input[1];

                if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                {
                    List<string> pos = new List<string>();
                    foreach (var item in players[firstPlayer])
                    {
                        pos.Add(item.Key);
                    }
                    foreach (var item in pos)
                    {
                        if (players[secondPlayer].ContainsKey(item))
                        {
                            if (players[firstPlayer][item] > players[secondPlayer][item])
                            {
                                players.Remove(secondPlayer);
                                totalSkill.Remove(secondPlayer);
                                break;
                            }
                            else
                            {
                                players.Remove(firstPlayer);
                                totalSkill.Remove(firstPlayer);
                                break;
                            }
                        }
                    }
                }
            }

            rawInput = Console.ReadLine();
            input = rawInput.Split(splitters, StringSplitOptions.None);
        }

        foreach (var player in players)
        {
            if (totalSkill.ContainsKey(player.Key))
            {
                foreach (var play in players[player.Key])
                {
                    totalSkill[player.Key] += play.Value;
                }
            }
        }

        foreach (var skills in totalSkill.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{skills.Key}: {skills.Value} skill");

            foreach (var player in players[skills.Key].OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"- {player.Key} <::> {player.Value}");
            }
        }
    }
}