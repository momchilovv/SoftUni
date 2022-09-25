using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var characters = new Dictionary<char, int>();

        string text = Console.ReadLine();

        foreach (var ch in text)
        {
            if (!characters.ContainsKey(ch))
            {
                characters.Add(ch, 1);
            }
            else
            {
                characters[ch]++;
            }
        }

        foreach (var ch in characters.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
        }
    }
}