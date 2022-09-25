using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split();

            string vlogger = input[0];
            if (vlogger == "Statistics")
            {
                break;
            }
            string action = input[1];
            string secondVlogger = input[2];

            

            if (action == "joined")
            {
                if (!vloggers.ContainsKey(vlogger))
                {
                    vloggers.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                    vloggers[vlogger].Add("following", new SortedSet<string>());
                    vloggers[vlogger].Add("followers", new SortedSet<string>());
                }
            }

            if (action == "followed")
            {
                if (vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(secondVlogger) && vlogger != secondVlogger)
                {
                    vloggers[vlogger]["following"].Add(secondVlogger);
                    vloggers[secondVlogger]["followers"].Add(vlogger);
                    
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        int count = 1;

        foreach (var vlogger in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
        {
            Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

            if (count == 1)
            {
                Console.WriteLine("*  " + string.Join("\r\n*  ", vlogger.Value["followers"]));
            }
            count++;
        }
    }
}