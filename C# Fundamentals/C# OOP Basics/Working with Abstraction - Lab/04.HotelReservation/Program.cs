using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split().ToArray();
        decimal pricePerDay = decimal.Parse(input[0]);
        int numberOfDays = int.Parse(input[1]);
        string season = input[2];
        string discountType = "None";
        if (input.Length == 4)
        {
            discountType = input[3];
        }
        decimal discount = 0.0m;
        int seasonPrice = 0;

        switch (season)
        {
            case "Autumn":
                seasonPrice = 1;
                break;
            case "Spring":
                seasonPrice = 2;
                break;
            case "Winter":
                seasonPrice = 3;
                break;
            case "Summer":
                seasonPrice = 4;
                break;
        }
        switch (discountType)
        {
            case "VIP":
                discount = 20m;
                break;
            case "SecondVisit":
                discount = 10m;
                break;
            case "None":
                discount = 0.0m;
                break;
            default:
                discount = 0.0m;                 
                break;
        }
        decimal price = pricePerDay * numberOfDays * seasonPrice;
        decimal totalPrice = price - price * (discount / 100);

        Console.WriteLine($"{totalPrice:f2}");
    }
}