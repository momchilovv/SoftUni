using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fisherCount = int.Parse(Console.ReadLine());

        double shipRentCost = 0;

        switch (season)
        {
            case "Summer":
            case "Autumn":
                shipRentCost = 4200;
                break;
            case "Spring":
                shipRentCost = 3000;
                break;
            case "Winter":
                shipRentCost = 2600;
                break;
        }
        if (fisherCount <= 6)
        {
            shipRentCost *= 0.90;
        }
        else if (fisherCount >= 7 && fisherCount <= 11)
        {
            shipRentCost *= 0.85;
        }
        else if (fisherCount > 12)
        {
            shipRentCost *= 0.75;
        }
        if (fisherCount % 2 == 0 && season != "Autumn")
        {
             shipRentCost *= 0.95; 
        }
        if (budget >= shipRentCost)
        {
            Console.WriteLine($"Yes! You have {budget - shipRentCost:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {shipRentCost - budget:f2} leva.");
        }
    }
}