using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> furniture = new List<string>();
        double totalSum = 0;

        Regex regex = new Regex(@">>([A-Za-z]+)<<([0-9]+[.]?[0-9]+)!([0-9]{1,})");

        string input = Console.ReadLine();

        while (input != "Purchase")
        {
            foreach (Match match in regex.Matches(input))
            {
                furniture.Add(match.Groups[1].Value);

                totalSum += double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("Bought furniture:");
        if (furniture.Count > 0)
        {
            Console.WriteLine(string.Join("\r\n", furniture));
        }
        Console.WriteLine($"Total money spend: {totalSum:f2}");
    }
}