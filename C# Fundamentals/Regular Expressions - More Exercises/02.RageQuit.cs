using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        StringBuilder convertedText = new StringBuilder();

        Regex regex = new Regex(@"([^\d]+)(\d+)");

        foreach (Match match in regex.Matches(input))
        {
            string currentText = match.Groups[1].Value;
            int repeatedTimes = int.Parse(match.Groups[2].Value);

            for (int i = 0; i < repeatedTimes; i++)
            {
                convertedText.Append(currentText.ToUpper());
            }
        }

        string uniqueSymbols = new string(convertedText.ToString().Distinct().ToArray());

        Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
        Console.WriteLine(convertedText);
    }
}