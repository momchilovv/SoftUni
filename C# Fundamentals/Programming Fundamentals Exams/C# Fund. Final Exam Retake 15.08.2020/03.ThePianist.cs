using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPieces = int.Parse(Console.ReadLine());
        SortedDictionary<string, string[]> pieces = new SortedDictionary<string, string[]>();

        for (int i = 0; i < numberOfPieces; i++)
        {
            string[] startPieces = Console.ReadLine().Split("|");
            pieces.Add(startPieces[0], new string[] { startPieces[1], startPieces[2] });
        }

        string[] command = Console.ReadLine().Split("|");

        while (command[0] != "Stop")
        {
            if (command[0] == "Add")
            {
                if (pieces.Keys.Contains(command[1]))
                {
                    Console.WriteLine($"{command[1]} is already in the collection!");
                }
                else
                {
                    pieces.Add(command[1], new string[] { command[2], command[3] });
                    Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                }
            }
            else if (command[0] == "Remove")
            {
                if (!pieces.Keys.Contains(command[1]))
                {
                    Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                }
                else
                {
                    pieces.Remove(command[1]);
                    Console.WriteLine($"Successfully removed {command[1]}!");
                }
            }
            else if (command[0] == "ChangeKey")
            {
                if (!pieces.Keys.Contains(command[1]))
                {
                    Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                }
                else
                {
                    foreach (var item in pieces)
                    {
                        if (item.Key == command[1])
                            item.Value[1] = command[2];
                    }
                    Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                }
            }
            command = Console.ReadLine().Split("|");
        }
        foreach (var item in pieces)
        {
            Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
        }
    }
}