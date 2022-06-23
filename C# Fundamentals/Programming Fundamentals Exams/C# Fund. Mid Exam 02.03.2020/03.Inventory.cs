using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] journal = Console.ReadLine().Split(", ");
        List<string> inventory = new List<string>();
        
        foreach (var item in journal)
        {
            inventory.Add(item);
        }

        string[] input = Console.ReadLine().Split(" - ");

        while (input[0] != "Craft!")
        {
            if (input[0] == "Collect")
            {
                if (!inventory.Contains(input[1]))
                {
                    inventory.Add(input[1]);
                }
            }
            else if (input[0] == "Drop")
            {
                if (inventory.Contains(input[1]))
                {
                    inventory.Remove(input[1]);
                }
            }
            else if (input[0] == "Combine Items")
            {
                string[] items = input[1].Split(":");

                if (inventory.Contains(items[0]))
                {
                    inventory.Insert(inventory.IndexOf(items[0]) + 1, items[1]);
                }
            }
            else if (input[0] == "Renew")
            {
                if (inventory.Contains(input[1]))
                {
                    inventory.Remove(input[1]);
                    inventory.Add(input[1]);
                }
            }
            input = Console.ReadLine().Split(" - ");
        }
        Console.WriteLine(string.Join(", ", inventory));
    }
}