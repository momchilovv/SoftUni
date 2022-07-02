using System;
using System.Collections.Generic;
using System.Linq;

class Project
{
    public string Creator { get; set; }

    public string Team { get; set; }

    public List<string> Members = new List<string>();
}

class Program
{
    static void Main(string[] args)
    {
        Project project = new Project();
        List<Project> projects = new List<Project>();

        int teamsNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < teamsNumber; i++)
        {
            string[] input = Console.ReadLine().Split("-");

            string creator = input[0], team = input[1];

            project = new Project()
            {
                Creator = creator,
                Team = team
            };

            bool containsTeam = projects.Any(t => t.Team == team);
            bool hasCreated = projects.Any(c => c.Creator == creator);

            if (containsTeam)
            {
                Console.WriteLine($"Team {team} was already created!");
            }

            else if (hasCreated)
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }

            else
            {
                projects.Add(project);
                Console.WriteLine($"Team {team} has been created by {creator}!");
            }
        }

        string[] command = Console.ReadLine().Split("->");

        while (command[0] != "end of assignment")
        {
            string user = command[0], team = command[1];

            bool teamExists = projects.Any(t => t.Team == team);
            bool containsUser = projects.Any(u => u.Members.Contains(user));
            bool isCreator = projects.Any(c => c.Creator == user);

            if (!teamExists)
            {
                Console.WriteLine($"Team {team} does not exist!");
            }
            else if (containsUser || isCreator)
            {
                Console.WriteLine($"Member {user} cannot join team {team}!");
            }
            else
            {
                foreach (var pr in projects)
                {
                    if (pr.Team == team && user != pr.Creator)
                    {
                        pr.Members.Add(user);
                    }
                }
            }

            command = Console.ReadLine().Split("->");
        }

        foreach (var pr in projects.OrderByDescending(m => m.Members.Count).ThenBy(t => t.Team).Where(m => m.Members.Count > 0))
        {
            pr.Members.Sort();
            Console.WriteLine($"{pr.Team}");
            Console.WriteLine($"- {pr.Creator}");
            Console.Write("-- ");
            Console.WriteLine(string.Join("\r\n-- ", pr.Members));
        }

        Console.WriteLine("Teams to disband:");
        foreach (var pr in projects.OrderBy(t => t.Team).Where(m => m.Members.Count < 1))
        {
            Console.WriteLine($"{pr.Team}");
        }
    }
}