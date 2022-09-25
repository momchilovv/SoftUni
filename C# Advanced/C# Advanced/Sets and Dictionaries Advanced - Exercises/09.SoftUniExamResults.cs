using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var participants = new Dictionary<string, int>();
        var languages = new Dictionary<string, int>();

        var input = Console.ReadLine().Split("-");

        while (input[0] != "exam finished")
        {
            string username = input[0];
            string language = input[1];

            if (input.Length == 2)
            {
                if (language == "banned" && participants.ContainsKey(username))
                {
                    participants.Remove(username);
                    continue;
                }
            }
            else
            {
                int points = int.Parse(input[2]);
                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 1);
                }
                else
                {
                    languages[language]++;
                }
                
                if (!participants.ContainsKey(username))
                {
                    participants.Add(username, points);
                }
                if (participants.ContainsKey(username) && points > participants[username])
                {
                    participants[username] = points;

                }
            }

            input = Console.ReadLine().Split("-");
        }

        Console.WriteLine("Results:");

        foreach (var participant in participants.OrderByDescending(p => p.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{participant.Key} | {participant.Value}");
        }

        Console.WriteLine("Submissions:");

        foreach (var language in languages.OrderByDescending(s => s.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{language.Key} - {language.Value}");
        }
    }
}