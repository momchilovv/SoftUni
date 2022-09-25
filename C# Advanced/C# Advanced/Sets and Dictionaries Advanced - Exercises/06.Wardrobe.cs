using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(" -> ");

            if (!wardrobe.ContainsKey(command[0]))
            {
                wardrobe.Add(command[0], new Dictionary<string, int>());
            }

            string[] clothes = command[1].Split(",");

            foreach (var cloth in clothes)
            {
                if (!wardrobe[command[0]].ContainsKey(cloth))
                {
                    wardrobe[command[0]].Add(cloth, 1);
                }
                else
                {
                    wardrobe[command[0]][cloth]++;
                }
            }
        }

        string[] input = Console.ReadLine().Split();

        string color = input[0];
        string type = input[1];

        foreach (var item in wardrobe)
        {
            Console.WriteLine($"{item.Key} clothes:");
            foreach (var cloth in item.Value)
            {
                Console.Write($"* {cloth.Key} - {cloth.Value}");
                
                if (item.Key == color && cloth.Key == type)
                {
                    Console.WriteLine($" (found!)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}