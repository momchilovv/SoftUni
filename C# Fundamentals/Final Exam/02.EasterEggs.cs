using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Regex regex = new Regex(@"(?:[#@]+)([a-z]{3,})(?:[@#]+)(?:[^\w]*?)(?:[/]+)(\d+)(?:[/]+)");

        foreach (Match match in regex.Matches(input))
        {
            Console.WriteLine($"You found {match.Groups[2].Value} {match.Groups[1].Value} eggs!");
        }
    }
}