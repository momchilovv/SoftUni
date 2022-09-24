using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var guests = new HashSet<string>();
        var vipGuests = new List<string>();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "PARTY")
            {
                break;
            }

            guests.Add(command);
        }

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "END")
            {
                break;
            }
            if (guests.Contains(command))
            {
                guests.Remove(command);
            }
        }

        Console.WriteLine(guests.Count);

        foreach (var guest in guests)
        {
            if (Char.IsDigit(guest[0]))
            {
                Console.WriteLine(guest);
                vipGuests.Add(guest);
            }
        }

        foreach (var guest in vipGuests)
        {
            guests.Remove(guest);
        }

        foreach (var guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}