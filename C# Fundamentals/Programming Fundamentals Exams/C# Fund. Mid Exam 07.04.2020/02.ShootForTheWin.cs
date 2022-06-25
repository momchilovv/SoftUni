using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

        string input = Console.ReadLine();
        int shotCount = 0;

        while (input != "End")
        {
            int index = int.Parse(input);

            if (index >= 0 && index < targets.Count)
            {
                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] > targets[index] && targets[i] != -1 && i != index)
                    {
                        targets[i] -= targets[index];
                    }
                    else if (targets[i] <= targets[index] && targets[i] != -1 && i != index)
                    {
                        targets[i] += targets[index];
                    }
                }
                targets[index] = -1;
                shotCount++;
            }
            input = Console.ReadLine();
        }
        Console.Write($"Shot targets: {shotCount} -> " + string.Join(" ", targets));
    }
}