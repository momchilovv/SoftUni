using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();

        string input = Console.ReadLine();
        string resource = null; 
        int count = 0, quantity;

        while (input != "stop")
        {
            if (count % 2 == 0)
            {
                resource = input;
            }
            else if (count % 2 == 1)
            {
                quantity = int.Parse(input);
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
            }
            
            count++;

            input = Console.ReadLine();
        }

        foreach (var res in resources)
        {
            Console.WriteLine($"{res.Key} -> {res.Value}");
        }
    }
}