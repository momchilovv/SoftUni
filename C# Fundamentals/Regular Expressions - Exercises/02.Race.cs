using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> participants = Console.ReadLine().Split(", ").ToList();
        Dictionary<string, int> raceInfo = new Dictionary<string, int>();

        Regex name = new Regex(@"[A-Za-z]");
        Regex distance = new Regex(@"[0-9]");

        string input = Console.ReadLine();

        while (input != "end of race")
        {
            string currentRacer = string.Empty;
            int kilometers = 0;

            foreach (Match match in name.Matches(input))
            {
                currentRacer += match.Value;
            }
            foreach (Match match in distance.Matches(input))
            {
                kilometers += int.Parse(match.Value);
            }

            if (participants.Contains(currentRacer))
            {
                if (raceInfo.ContainsKey(currentRacer))
                {
                    raceInfo[currentRacer] += kilometers;
                }
                else
                {
                    raceInfo.Add(currentRacer, kilometers);
                }
            }

            input = Console.ReadLine();
        }

        int place = 1;
        foreach (var racer in raceInfo.OrderByDescending(km => km.Value))
        {
            if (place == 1)
            {
                Console.WriteLine($"1st place: {racer.Key}");
                place++;
            }
            else if (place == 2)
            {
                Console.WriteLine($"2nd place: {racer.Key}");
                place++;
            }
            else
            {
                Console.WriteLine($"3rd place: {racer.Key}");
                break;
            }
        }
    }
}