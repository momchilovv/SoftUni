using System;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee") Console.WriteLine(value * 0.50);
                else if (product == "water") Console.WriteLine(value * 0.80);
                else if (product == "beer") Console.WriteLine(value * 1.20);
                else if (product == "sweets") Console.WriteLine(value * 1.45);
                else if (product == "peanuts") Console.WriteLine(value * 1.60);
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee") Console.WriteLine(value * 0.40);
                else if (product == "water") Console.WriteLine(value * 0.70);
                else if (product == "beer") Console.WriteLine(value * 1.15);
                else if (product == "sweets") Console.WriteLine(value * 1.30);
                else if (product == "peanuts") Console.WriteLine(value * 1.50);
            }
            else if (town == "varna")
            {
                if (product == "coffee") Console.WriteLine(value * 0.45);
                else if (product == "water") Console.WriteLine(value * 0.70);
                else if (product == "beer") Console.WriteLine(value * 1.10);
                else if (product == "sweets") Console.WriteLine(value * 1.35);
                else if (product == "peanuts") Console.WriteLine(value * 1.55);
            }
        }
    }
}