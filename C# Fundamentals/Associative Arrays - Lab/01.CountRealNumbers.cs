using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<double, int> appereances = new Dictionary<double, int>();
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (var number in numbers)
        {
            if (!appereances.ContainsKey(number))
            {
                appereances.Add(number, 1); 
            }
            else
            {
                appereances[number]++;
            }
        }
        foreach (var item in appereances.OrderBy(i => i.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}