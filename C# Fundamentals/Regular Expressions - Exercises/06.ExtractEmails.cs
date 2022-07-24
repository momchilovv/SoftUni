using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Regex regex = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");

        string input = Console.ReadLine();

        foreach (Match match in regex.Matches(input))
        {
            Console.WriteLine(match.Value);
        }
    }
}