using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, int> chars = new Dictionary<char, int>();

        string[] input = Console.ReadLine().Split();

        foreach (var item in input)
        {
            foreach (var ch in item)
            {
                if (!chars.ContainsKey(ch))
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        break;
                    }
                    chars.Add(ch, 1);
                }
                else
                {
                    chars[ch]++;
                }
            }      
        }
        foreach (var ch in chars)
        {
            Console.WriteLine($"{ch.Key} -> {ch.Value}");
        }
    }
}