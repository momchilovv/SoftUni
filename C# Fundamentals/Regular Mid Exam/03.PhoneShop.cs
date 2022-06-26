using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> phones = Console.ReadLine().Split(", ").ToList();

        string[] command = Console.ReadLine().Split(" - ");

        while (command[0] != "End")
        {
            if (command[0] == "Add")
            {
                if (!phones.Contains(command[1]))
                {
                    phones.Add(command[1]);
                }
            }
            else if (command[0] == "Remove")
            {
                if (phones.Contains(command[1]))
                {
                    phones.Remove(command[1]);
                }
            }
            else if (command[0] == "Bonus phone")
            {
                string[] phone = command[1].Split(":");

                if (phones.Contains(phone[0]))
                {
                    phones.Insert(phones.IndexOf(phone[0]) + 1, phone[1]);
                }
            }
            else if (command[0] == "Last")
            {
                if (phones.Contains(command[1]))
                {
                    phones.Remove(command[1]);
                    phones.Add(command[1]);
                }
            }
            command = Console.ReadLine().Split(" - ");
        }
        Console.WriteLine(string.Join(", ", phones));
    }
}