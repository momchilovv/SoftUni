using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var stores = new Dictionary<string, Dictionary<string, double>>();

        string[] command = Console.ReadLine().Split(", ");

        while (command[0] != "Revision")
        {
            string storeName = command[0];
            string productName = command[1];
            double price = double.Parse(command[2]);

            if (!stores.ContainsKey(storeName))
            {
                stores.Add(storeName, new Dictionary<string, double>());
            }
            if (!stores[storeName].ContainsKey(productName))
            {
                stores[storeName].Add(productName, price);
            }


            command = Console.ReadLine().Split(", ");
        }

        foreach (var store in stores.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{store.Key}->");

            foreach (var product in stores[store.Key])
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}