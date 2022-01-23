using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        switch (season)
        {
            case "summer":
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget -= (budget * 0.70):f2}");
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget -= (budget * 0.60):f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {budget -= (budget * 0.10):f2}");
                }
                break;
            case "winter":
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget -= (budget * 0.30):f2}");
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget -= (budget * 0.20):f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {budget -= (budget * 0.10):f2}");
                }
                break;
        }
    }
}