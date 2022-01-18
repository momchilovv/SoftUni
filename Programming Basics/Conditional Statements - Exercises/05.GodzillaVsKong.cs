using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int actors = int.Parse(Console.ReadLine());
        double pricePerActor = double.Parse(Console.ReadLine());

        double decorPrice = budget * 0.1;

        if (actors > 150)
        {
            pricePerActor = pricePerActor - (pricePerActor * 0.1);
        }

        double neededMoney = decorPrice + (pricePerActor * actors);

        if (budget >= neededMoney)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {budget - neededMoney:f2} leva left.");
        }
        else if (budget < neededMoney)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {neededMoney - budget:f2} leva more.");
        }
    }
}