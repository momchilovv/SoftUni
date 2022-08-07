using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            string heroName = command[1];
            
            if (command[0] == "Enroll")
            {
                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new List<string>());
                }
                else
                {
                    Console.WriteLine($"{heroName} is already enrolled.");
                }
            }

            if (command[0] == "Learn")
            {
                string spell = command[2];
                if (heroes.ContainsKey(heroName))
                {
                    if (!heroes[heroName].Contains(spell))
                    {
                        heroes[heroName].Add(spell);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has already learnt {spell}.");
                    }
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't exist.");
                }
            }

            if (command[0] == "Unlearn")
            {
                string spell = command[2];

                if (heroes.ContainsKey(heroName))
                {
                    if (heroes[heroName].Contains(spell))
                    {
                        heroes[heroName].Remove(spell);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't know {spell}.");
                    }
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't exist.");
                }
            }

            command = Console.ReadLine().Split();
        }

        Console.WriteLine("Heroes:");

        foreach (var hero in heroes)
        {
            Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
        }
    }
}