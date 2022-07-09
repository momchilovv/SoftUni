using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

        string[] product = Console.ReadLine().Split();

        while (product[0] != "buy")
        {
            string name = product[0];
            double price = double.Parse(product[1]);
            int quantity = int.Parse(product[2]);

            if (!products.ContainsKey(name))
            {
                var temp = new List<double>();
                temp.Add(price);
                temp.Add(quantity);
                products.Add(name, temp);
            }
            else
            {
                foreach (var pr in products.Where(p => p.Key == name))
                {
                    products[name][0] = price;
                    products[name][1] += quantity;
                }
            }
            product = Console.ReadLine().Split();
        }
        foreach (var pr in products)
        {
            Console.WriteLine($"{pr.Key} -> {pr.Value[0] * pr.Value[1]:f2}");
        }
    }
}