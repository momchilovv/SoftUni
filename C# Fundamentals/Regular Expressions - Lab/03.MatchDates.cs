using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Regex regex = new Regex(@"\b([0-9]{2})(-|.|\/)([A-Za-z]{3})(\2)([0-9]{4})\b");

        string dates = Console.ReadLine();

        foreach (Match match in regex.Matches(dates))
        {
            Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[5].Value}");
        }
    }
}