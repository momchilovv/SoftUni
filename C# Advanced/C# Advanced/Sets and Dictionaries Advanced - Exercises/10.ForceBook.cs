using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var usernames = new Dictionary<string, string>();
        var sides = new Dictionary<string, List<string>>();

        string[] command = null;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Lumpawaroo")
            {
                break;
            }

            if (input.Contains("|"))
            {
                command = input.Split(" | ");

                string forceSide = command[0];
                string forceUser = command[1];

                if (!usernames.ContainsKey(forceUser))
                {
                    usernames.Add(forceUser, forceSide);
                }
            }
            else if (input.Contains("->"))
            {
                command = input.Split(" -> ");

                string forceUser = command[0];
                string forceSide = command[1];

                if (!usernames.ContainsKey(forceUser))
                {
                    usernames.Add(forceUser, forceSide);
                }
                else
                {
                    usernames[forceUser] = forceSide;
                }
                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }
        }

        foreach (var user in usernames)
        {
            if (!sides.ContainsKey(user.Value))
            {
                sides.Add(user.Value, new List<string>());
            }
            sides[user.Value].Add(user.Key);
        }

        foreach (var side in sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

            foreach (var user in side.Value.OrderBy(x => x))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}