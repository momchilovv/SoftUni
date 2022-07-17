using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        double sum = 0, result = 0;

        char[] alphabetUpper = "0ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] alphabetLower = "0abcdefghijklmnopqrstuvwxyz".ToCharArray();

        foreach (var seq in input)
        {
            char firstLetter = seq.First();
            char lastLetter = seq.Last();

            double number = int.Parse(seq.Substring(1, seq.Length - 2).ToString());

            if (alphabetUpper.Contains(firstLetter))
            {
                for (int i = 0; i < alphabetUpper.Length; i++)
                {
                    if (firstLetter == alphabetUpper[i])
                    {
                        result = number / i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < alphabetLower.Length; i++)
                {
                    if (firstLetter == alphabetLower[i])
                    {
                        result = number * i;
                        break;
                    }
                }
            }
            if (alphabetUpper.Contains(lastLetter))
            {
                for (int i = 0; i < alphabetUpper.Length; i++)
                {
                    if (lastLetter == alphabetUpper[i])
                    {
                        sum += result - i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < alphabetLower.Length; i++)
                {
                    if (lastLetter == alphabetLower[i])
                    {
                        sum += result + i;
                    }
                }
            }
        }

        Console.WriteLine($"{sum:f2}");
    }
}