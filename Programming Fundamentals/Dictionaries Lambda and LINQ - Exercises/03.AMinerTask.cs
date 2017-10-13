using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(input))                
                    resources[input] += quantity;
                
                else              
                    resources.Add(input, quantity);

                input = Console.ReadLine();
                if (input == "stop")          
                    break;
            }
            foreach (var good in resources)
            {
                Console.WriteLine($"{good.Key} -> {good.Value}");
            }
        }
    }
}