using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();
        List<int> housesCelebrated = new List<int>();
        int cupidIndex = 0;

        while (true)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "Love!")
            {
                break;
            }
            if (command[0] == "Jump")
            {
                int index = int.Parse(command[1]);

                if (cupidIndex  + index > neighborhood.Count - 1)
                {
                    cupidIndex = 0;
                    if (neighborhood[cupidIndex] == 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                    }
                    else
                    {
                        neighborhood[cupidIndex] -= 2;
                        if (neighborhood[cupidIndex] == 0)
                        {
                            Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                            if (!housesCelebrated.Contains(cupidIndex))
                            {
                                housesCelebrated.Add(cupidIndex);
                            }
                        }
                    }
                }
                else
                {
                    cupidIndex += index;
                    if (neighborhood[cupidIndex] == 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                    }
                    neighborhood[cupidIndex] -= 2;
                    if (neighborhood[cupidIndex] == 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                        if (!housesCelebrated.Contains(cupidIndex))
                        {
                            housesCelebrated.Add(cupidIndex);
                        }
                    }
                }
            }
        }
        Console.WriteLine($"Cupid's last position was {cupidIndex}.");
        if (neighborhood.Count == housesCelebrated.Count)
        {
            Console.WriteLine("Mission was successful.");
        }
        else
        {
            Console.WriteLine($"Cupid has failed {neighborhood.Count - housesCelebrated.Count} places.");
        }
    }
}