using System;

class Program
{
    static void Main(string[] args)
    {
        string flowerType = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double finalPrice;

        switch (flowerType)
        {
            case "Roses":
                finalPrice = quantity * 5;
                if (quantity > 80)
                    finalPrice -= finalPrice * 0.10;

                if (budget >= finalPrice)
                {
                    Console.WriteLine($"Hey, you have a great garden with " +
                    $"{quantity} {flowerType} and {budget - finalPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
                }
                break;
            case "Dahlias":
                finalPrice = quantity * 3.80;
                if (quantity > 90)
                    finalPrice -= finalPrice * 0.15;

                if (budget >= finalPrice)
                {
                    Console.WriteLine($"Hey, you have a great garden with " +
                    $"{quantity} {flowerType} and {budget - finalPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
                }
                break;
            case "Tulips":
                finalPrice = quantity * 2.80;
                if (quantity > 80)
                    finalPrice -= finalPrice * 0.15;

                if (budget >= finalPrice)
                {
                    Console.WriteLine($"Hey, you have a great garden with " +
                    $"{quantity} {flowerType} and {budget - finalPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
                }
                break;
            case "Narcissus":
                finalPrice = quantity * 3;
                if (quantity < 120)
                    finalPrice += finalPrice * 0.15;

                if (budget >= finalPrice)
                {

                    Console.WriteLine($"Hey, you have a great garden with " +
                    $"{quantity} {flowerType} and {budget - finalPrice:f2} leva left.");

                }
                else if (budget < finalPrice)
                {
                    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
                }
                break;
            case "Gladiolus":
                finalPrice = quantity * 2.50;
                if (quantity < 80)
                    finalPrice += finalPrice * 0.20;

                if (budget >= finalPrice)
                {
                    Console.WriteLine($"Hey, you have a great garden with " +
                    $"{quantity} {flowerType} and {budget - finalPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
                }
                break;
        }
    }
}