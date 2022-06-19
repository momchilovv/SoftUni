using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> guestList = new List<string>();
        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[2] == "going!")
            {
                if (!guestList.Contains(command[0]))
                {
                    guestList.Add(command[0]);
                }
                else if (guestList.Contains(command[0]))
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
            }       
            else if (command[2] == "not")
            {
                if (guestList.Contains(command[0]))
                {
                    guestList.Remove(command[0]);
                }
                else
                {
                    Console.WriteLine($"{command[0]} is not in the list!");

                }
            }
        }
        foreach (var name in guestList)
        {
            Console.WriteLine(name);
        }
    }
}