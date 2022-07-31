using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split("|");

        string firstPart = input[0];
        string secondPart = input[1];
        string thirdPart = input[2];

        string firstPattern = @"([\#|\$|\%|\*|\&])([A-Z]+)\1";

        Match firstMatch = Regex.Match(firstPart, firstPattern);
        string letters = firstMatch.Groups[2].Value;

        foreach (var letter in letters)
        {
            string secondPattern = @$"{(int)letter}\:([0-9][0-9])";
            Match secondMatch = Regex.Match(secondPart, secondPattern);

            int length = int.Parse(secondMatch.Groups[1].Value);

            string thirdPattern = @$"(?<=\s|^){letter}[^\s]{{{length}}}(?=\s|$)";
            Match thirdMatch = Regex.Match(thirdPart, thirdPattern);

            Console.WriteLine(thirdMatch.Value);
        }
    }
}