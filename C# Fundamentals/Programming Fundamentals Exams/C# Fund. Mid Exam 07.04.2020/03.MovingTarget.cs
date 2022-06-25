using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            int index = int.Parse(command[1]), value = int.Parse(command[2]);

            if (command[0] == "Shoot")
            {
                if (index >= 0 && index <= targets.Count - 1)
                {
                    targets[index] -= value;
                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }
            }
            else if (command[0] == "Add")
            {
                if (index < 0 || index > targets.Count - 1)
                {
                    Console.WriteLine("Invalid placement!");
                }
                else
                {
                    targets.Insert(index, value);
                }
            }
            else if (command[0] == "Strike")
            {
                if (index - value < 0 || index + value > targets.Count - 1)
                {
                    Console.WriteLine("Strike missed!");
                }
                else
                {
                    targets.RemoveRange(index - value, (value * 2) + 1);
                }
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join("|", targets));
    }
}