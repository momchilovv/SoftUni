using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> groceries = Console.ReadLine().Split("!").ToList();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "Go")
        {
            if (command[0] == "Urgent")
            {
                if (!groceries.Contains(command[1]))
                {
                    groceries.Insert(0, command[1]);
                }
            }
            else if (command[0] == "Unnecessary")
            {
                if (groceries.Contains(command[1]))
                {
                    groceries.Remove(command[1]);
                }
            }
            else if (command[0] == "Correct")
            {
                if (groceries.Contains(command[1]))
                {
                    int index = groceries.IndexOf(command[1]);
                    groceries.Insert(index, command[2]);
                    groceries.Remove(command[1]);
                }
            }
            else if (command[0] == "Rearrange")
            {
                if (groceries.Contains(command[1]))
                {
                    groceries.Remove(command[1]);
                    groceries.Add(command[1]);
                }
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(", ", groceries));
    }
}