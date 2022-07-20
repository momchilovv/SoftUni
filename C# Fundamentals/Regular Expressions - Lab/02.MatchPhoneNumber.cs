using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> validNumbers = new List<string>();

        Regex regex = new Regex(@"((\+[359]{3} [2] [0-9]{3} [0-9]{4})|(\+[359]{3}-[2]-[0-9]{3}-[0-9]{4}))\b");

        string phoneNumbers = Console.ReadLine();

        foreach (Match match in regex.Matches(phoneNumbers))
        {
            validNumbers.Add(match.Value);
        }
        Console.WriteLine(string.Join(", ", validNumbers));
    }
}