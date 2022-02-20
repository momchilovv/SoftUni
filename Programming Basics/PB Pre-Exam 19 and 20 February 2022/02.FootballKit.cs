using System;

class Program
{
    static void Main(string[] args)
    {
        double tshirt = double.Parse(Console.ReadLine());
        double priceToReach = double.Parse(Console.ReadLine());

        double shortsPrice = tshirt * 0.75;
        double socksPrice = shortsPrice * 0.20;
        double shoesPrice = 2 * (shortsPrice + tshirt);

        double finalPrice = (tshirt + shortsPrice + socksPrice + shoesPrice) * 0.85;

        if (finalPrice >= priceToReach)
        {
            Console.WriteLine("Yes, he will earn the world-cup replica ball!");
            Console.WriteLine($"His sum is {finalPrice:f2} lv.");
        }
        else
        {
            Console.WriteLine("No, he will not earn the world-cup replica ball.");
            Console.WriteLine($"He needs {priceToReach - finalPrice:f2} lv. more.");
        }
    }
}