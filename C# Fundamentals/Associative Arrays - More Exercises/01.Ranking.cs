using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contests = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, double>> candidates = new Dictionary<string, Dictionary<string, double>>();

        string[] contest = Console.ReadLine().Split(":");

        while (contest[0] != "end of contests")
        {
            contests.Add(contest[0], contest[1]);

            contest = Console.ReadLine().Split(":");
        }

        string[] input = Console.ReadLine().Split("=>");

        while (input[0] != "end of submissions")
        {
            string module = input[0], password = input[1], username = input[2];
            double points = double.Parse(input[3]);

            foreach (var cont in contests.Where(c => c.Key == module).Where(c => c.Value == password))
            {
                var dict = new Dictionary<string, double>();
                dict.Add(module, points);

                if (!candidates.ContainsKey(username))
                {
                    candidates.Add(username, dict);
                }
                else
                {
                    if (candidates[username].ContainsKey(module))
                    {
                        if (candidates[username][module] < points)
                        {
                            candidates[username][module] = points;
                        }
                    }
                    else
                    {
                        candidates[username].Add(module, points);
                    }
                }
            }

            input = Console.ReadLine().Split("=>");
        }

        string bestCandidate = null;
        double bestScore = 0;

        foreach (var cont in candidates)
        {
            if (cont.Value.Values.Sum() > bestScore)
            {
                bestScore = cont.Value.Values.Sum();
                bestCandidate = cont.Key;
            }
        }

        Console.WriteLine($"Best candidate is {bestCandidate} with total {bestScore} points.");
        Console.WriteLine("Ranking: ");

        foreach (var user in candidates.OrderBy(n => n.Key))
        {
            Console.WriteLine($"{user.Key}");
            foreach (var cont in user.Value.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"#  {cont.Key} -> {cont.Value}");
            }
        }
    }
}