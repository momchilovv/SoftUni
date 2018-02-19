using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Person> persons = new List<Person>();
        Team team = new Team("SoftUni");

        for (int i = 0; i < lines; i++)
        {
            string[] commands = Console.ReadLine().Split();
            Person person = new Person(commands[0], commands[1], int.Parse(commands[2]), decimal.Parse(commands[3]));

            persons.Add(person);
        }
        foreach (Person p in persons)
        {
            team.AddPlayer(p);
        }
        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reseve team has {team.ReserveTeam.Count} players.");
    }
}