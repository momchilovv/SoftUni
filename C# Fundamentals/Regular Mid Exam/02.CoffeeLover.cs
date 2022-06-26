using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> coffee = Console.ReadLine().Split().ToList();

        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "Include")
            {
                coffee.Add(command[1]);
            }
            else if (command[0] == "Remove")
            {
                if (command[1] == "first")
                {
                    if (int.Parse(command[2]) <= coffee.Count)
                    {
                        coffee.RemoveRange(0, int.Parse(command[2]));
                    }
                }
                else if (command[1] == "last")
                {
                    if (int.Parse(command[2]) <= coffee.Count)
                    {
                        coffee.Reverse();
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            coffee.RemoveAt(0);
                        }
                    }
                    coffee.Reverse();
                }
            }
            else if (command[0] == "Prefer")
            {
                if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= coffee.Count && int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= coffee.Count)
                {
                    int firstIndex = int.Parse(command[1]), secondIndex = int.Parse(command[2]);

                    string temp = coffee[secondIndex];
                    coffee[secondIndex] = coffee[firstIndex];
                    coffee[firstIndex] = temp;
                }
            }
            else if (command[0] == "Reverse")
            {
                coffee.Reverse();
            }
        }
        Console.WriteLine("Coffees:");
        Console.WriteLine(string.Join(" ", coffee));
    }
}