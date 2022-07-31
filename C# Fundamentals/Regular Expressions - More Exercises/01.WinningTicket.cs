using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        Regex regex = new Regex(@"\@{6,10}|\${6,10}|\#{6,10}|\^{6,10}");

        foreach (var ticket in input)
        {
            if (ticket.Length == 20)
            {
                Match firstHalf = regex.Match(ticket.Substring(0, 10));
                Match secondHalf = regex.Match(ticket.Substring(10, 10));
                int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

                if (firstHalf.Success && secondHalf.Success)
                {
                    string winningFirstPart = firstHalf.Value.Substring(0, minLength);
                    string winningSecondPart = firstHalf.Value.Substring(0, minLength);

                    if (winningFirstPart == winningSecondPart)
                    {
                        if (winningFirstPart.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{winningFirstPart.Substring(0, 1)} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minLength}{winningFirstPart.Substring(0,1)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }
}