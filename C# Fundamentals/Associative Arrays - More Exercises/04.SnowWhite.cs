using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

        string[] input = Console.ReadLine().Split(" <:> ");

        while (input[0] != "Once upon a time")
        {
            string dwarfName = input[0], hatColor = input[1];
            int dwarfPhysics = int.Parse(input[2]);

            if (!dwarfs.ContainsKey(hatColor))
            {
                dwarfs[hatColor] = new Dictionary<string, int>();
                dwarfs[hatColor].Add(dwarfName, dwarfPhysics);
            }
            else
            {
                if (dwarfs[hatColor].ContainsKey(dwarfName))
                {
                    if (dwarfs[hatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarfs[hatColor][dwarfName] = dwarfPhysics;
                    }
                }
                else
                {
                    dwarfs[hatColor].Add(dwarfName, dwarfPhysics);
                }
            }
            input = Console.ReadLine().Split(" <:> ");
        }

        var sortedDwarfs = new Dictionary<string, int>();
        foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value.Count()))
        {
            string hatColor = dwarf.Key;
            var namesAndPhysics = dwarf.Value;
            foreach (var dw in namesAndPhysics)
            {
                string dwarfName = dw.Key;
                int dwarfPhysics = dw.Value;

                sortedDwarfs.Add($"({hatColor}) {dwarfName} <-> ", dwarfPhysics);
            }
        }

        foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
        {
            string dwarfName = dwarf.Key;
            int dwarfPhysics = dwarf.Value;
            Console.WriteLine($"{dwarfName}{dwarfPhysics}");
        }
    }
}