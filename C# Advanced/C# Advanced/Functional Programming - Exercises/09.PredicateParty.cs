using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        
        string[] command = Console.ReadLine().Split();

        Predicate<string> startsWith = name => name.StartsWith(command[2]);
        Predicate<string> endsWith = name => name.EndsWith(command[2]);
        Predicate<string> length = name => name.Length == int.Parse(command[2]);

        while (command[0] != "Party!")
        {
            if (command[0] == "Double")
            {
                var people = new List<string>();
                int index = -1;
                switch (command[1])
                {
                    case "StartsWith":
                        people = guests.FindAll(startsWith);
                        index = guests.FindIndex(startsWith);
                        if (index != -1)
                        {
                            guests.InsertRange(index, people);
                        }
                        break;
                    case "EndsWith":
                        people = guests.FindAll(endsWith);
                        index = guests.FindIndex(endsWith);
                        if (index != -1)
                        {
                            guests.InsertRange(index, people);
                        }
                        break;
                    case "Length":
                        people = guests.FindAll(length);
                        index = guests.FindIndex(length);
                        if (index != -1)
                        {
                            guests.InsertRange(index, people);
                        }
                        break;
                }
            }
            if (command[0] == "Remove")
            {
                switch (command[1])
                {
                    case "StartsWith":
                        guests.RemoveAll(startsWith);
                        break;
                    case "EndsWith":
                        guests.RemoveAll(endsWith);
                        break;
                    case "Length":
                        guests.RemoveAll(length);
                        break;
                }
            }
            command = Console.ReadLine().Split();
        }

        if (guests.Count > 0)
        {
            Console.WriteLine(String.Join(", ", guests) + " are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}