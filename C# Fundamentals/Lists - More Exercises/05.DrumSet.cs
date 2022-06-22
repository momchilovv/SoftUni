using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double savings = double.Parse(Console.ReadLine());
        List<int> initialQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> quality = new List<int>(initialQuality);

        string command = Console.ReadLine();

        while (command != "Hit it again, Gabsy!")
        {
            int power = int.Parse(command);
            for (int i = 0; i < quality.Count; i++)
            {
                quality[i] -= power;
                if (quality[i] <= 0)
                {
                    int price = initialQuality[i] * 3;
                    if (savings >= price)
                    {
                        savings -= price;
                        quality[i] = initialQuality[i];
                    }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", quality.Where(x => x > 0)));
        Console.WriteLine($"Gabsy has {savings:f2}lv.");
    }
}