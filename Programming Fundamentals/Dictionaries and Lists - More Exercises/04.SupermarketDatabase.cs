using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<decimal>>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "stocked")
            {
                string item = input[0].ToString();
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);

                if (!dict.ContainsKey(item))
                {
                    dict[item] = new List<decimal>();
                    dict[item].Add(price);
                    dict[item].Add(quantity);
                }
                else
                {
                    dict[item][0] = price;
                    dict[item][1] += quantity;
                }
                input = Console.ReadLine().Split().ToArray();
            }
            decimal total = 0m;
            foreach (var d in dict)
            {
                total += d.Value[0] * d.Value[1];
                Console.WriteLine($"{d.Key}: ${d.Value[0]:f2} * {d.Value[1]} = ${(d.Value[0] * d.Value[1]):f2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}