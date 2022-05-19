using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfOrders = int.Parse(Console.ReadLine());

        double pricePerCapsule;
        int days, capsulesCount;
        double total = 0;

        for (int i = 0; i < numberOfOrders; i++)
        {
            pricePerCapsule = double.Parse(Console.ReadLine());
            days = int.Parse(Console.ReadLine());
            capsulesCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"The price for the coffee is: ${((days * capsulesCount) * pricePerCapsule):f2}");
            total += ((days * capsulesCount) * pricePerCapsule);
        }
        Console.WriteLine($"Total: ${total:f2}");
    }
}