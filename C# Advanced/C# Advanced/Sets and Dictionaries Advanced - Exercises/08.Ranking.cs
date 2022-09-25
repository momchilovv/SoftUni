using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var contests = new Dictionary<string, string>();

        var submissions = new Dictionary<string, Dictionary<string, int>>();

        string bestCandidateName = string.Empty;
        int bestCandidatePoints = 0;

        string[] contestInput = Console.ReadLine().Split(":");

        while (contestInput[0] != "end of contests")
        {
            contests.Add(contestInput[0], contestInput[1]);

            contestInput = Console.ReadLine().Split(":");
        }

        string[] submissionInput = Console.ReadLine().Split("=>");

        while (submissionInput[0] != "end of submissions")
        {
            string contestName = submissionInput[0];
            string contestPass = submissionInput[1];
            string participant = submissionInput[2];
            int points = int.Parse(submissionInput[3]);

            if (contests.ContainsKey(contestName) && contests[contestName] == contestPass)
            {
                if (!submissions.ContainsKey(participant))
                {
                    submissions.Add(participant, new Dictionary<string, int>());


                }
                if (submissions[participant].ContainsKey(contestName))
                {
                    if (points > submissions[participant][contestName])
                    {
                        submissions[participant][contestName] = points;
                    }
                }
                else
                {
                    submissions[participant].Add(contestName, points);
                }
            }
            submissionInput = Console.ReadLine().Split("=>");
        }

        foreach (var submit in submissions)
        {
            int currentPoints = 0;
            foreach (var participant in submit.Value)
            {
                currentPoints += participant.Value;
            }

            if (currentPoints > bestCandidatePoints)
            {
                bestCandidateName = submit.Key;
                bestCandidatePoints = currentPoints;
            }
        }

        Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
        Console.WriteLine("Ranking:");

        foreach (var submit in submissions.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{submit.Key}");
            foreach (var participant in submit.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {participant.Key} -> {participant.Value}");
            }
        }
    }
}