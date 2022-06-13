using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int calSum = 0;
        int daysLeft = 0;

        string pattern = @"([#\|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            calSum += int.Parse(match.Groups["calories"].Value);
        }

        daysLeft = calSum / 2000;
        Console.WriteLine($"You have food to last you for: {daysLeft} days!");
        foreach (Match item in matches)
        {
            Console.WriteLine($"Item: {item.Groups["name"].Value}, " +
                $"Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"]}");
        }
    }
}