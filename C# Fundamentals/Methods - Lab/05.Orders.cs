using System;

class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        Order(product, quantity);
    }
    public static void Order(string product, int quantity)
    {
        switch (product)
        {
            case "water":
                Console.WriteLine($"{1.00 * quantity:f2}");
                break;
            case "coffee":
                Console.WriteLine($"{1.50 * quantity:f2}");
                break;
            case "coke":
                Console.WriteLine($"{1.40 * quantity:f2}");
                break;
            case "snacks":
                Console.WriteLine($"{2.00 * quantity:f2}");
                break;
        }
    }
}