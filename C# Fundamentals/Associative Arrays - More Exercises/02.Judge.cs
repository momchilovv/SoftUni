using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, int> standings = new Dictionary<string, int>();
        int place = 1;

        string[] input = Console.ReadLine().Split(" -> ");

        while (input[0] != "no more time")
        {
            string username = input[0], contestName = input[1];
            int points = int.Parse(input[2]);

            if (!standings.ContainsKey(username))
            {
                standings.Add(username, 0);
            }
            if (!contests.ContainsKey(contestName))
            {
                var temp = new Dictionary<string, int>();
                temp.Add(username, points);
                contests.Add(contestName, temp);
            }
            else if (!contests[contestName].ContainsKey(username))
            {
                contests[contestName].Add(username, points);
            }
            if (contests[contestName][username] < points)
            {
                contests[contestName][username] = points;
            }
            

            input = Console.ReadLine().Split(" -> ");
        }

        foreach (var contest in contests)
        {
            Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

            foreach (var user in contest.Value.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{place}. {user.Key} <::> {user.Value}");
                if (standings.ContainsKey(user.Key))
                {
                    standings[user.Key] += user.Value;
                }
                place++;
            }
            place = 1;
        }

        Console.WriteLine($"Individual standings:");

        foreach (var participants in standings.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{place}. {participants.Key} -> {participants.Value}");
            place++;
        }
    }
}