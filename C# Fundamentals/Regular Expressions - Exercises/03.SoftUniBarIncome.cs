using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
        
        double totalIncome = 0;

        string input = Console.ReadLine();

        while (input != "end of shift")
        {
            if (Regex.IsMatch(input, pattern)) 
            {
                Match match = Regex.Match(input, pattern);

                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double sum = price * quantity;

                Console.WriteLine($"{customer}: {product} - {sum:f2}");

                totalIncome += sum;
            }

            input = Console.ReadLine();
        }
        Console.WriteLine($"Total income: {totalIncome:f2}");
    }
}