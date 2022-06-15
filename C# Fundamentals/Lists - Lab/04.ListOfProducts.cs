using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        List<string> products = new List<string>();

        for (int i = 0; i < number; i++)
        {
            products.Add(Console.ReadLine());
        }

        products.Sort();

        foreach (var item in products)
        {
            Console.WriteLine($"{products.IndexOf(item) + 1}.{item}");
        }
    }
}