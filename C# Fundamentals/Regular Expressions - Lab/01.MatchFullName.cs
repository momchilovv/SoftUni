using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        string names = Console.ReadLine();

        foreach (Match match in regex.Matches(names))
        {
            Console.Write($"{match.Value} ");
        }
        Console.WriteLine();
    }
}