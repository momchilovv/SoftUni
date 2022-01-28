using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double balance = 0;

        while (input != "NoMoreMoney")
        {
            if (double.Parse(input) < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            balance += double.Parse(input);
            Console.WriteLine($"Increase: {double.Parse(input):f2}");
            input = Console.ReadLine();
        }
        Console.WriteLine($"Total: {balance:f2}");
    }
}