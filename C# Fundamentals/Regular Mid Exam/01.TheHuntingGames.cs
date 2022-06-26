using System;

class Program
{
    static void Main(string[] args)
    {
        int daysOfAdventure = int.Parse(Console.ReadLine());
        int numberOfPlayers = int.Parse(Console.ReadLine());
        double groupEnergy = double.Parse(Console.ReadLine());
        double waterPerDay = double.Parse(Console.ReadLine());
        double foodPerDay = double.Parse(Console.ReadLine());

        double waterSupply = daysOfAdventure * numberOfPlayers * waterPerDay;
        double foodSupply = daysOfAdventure * numberOfPlayers * foodPerDay;

        for (int i = 1; i <= daysOfAdventure; i++)
        {
            double energyLoss = double.Parse(Console.ReadLine());
            if (groupEnergy - energyLoss <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodSupply:f2} food and {waterSupply:f2} water.");
                Environment.Exit(0);
            }

            groupEnergy -= energyLoss;

            if (i % 2 == 0)
            {
                groupEnergy += groupEnergy * 0.05;
                waterSupply *= 0.70;
            }
            if (i % 3 == 0)
            {
                foodSupply -= foodSupply / numberOfPlayers;
                groupEnergy += groupEnergy * 0.10;
            }
        }
        Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
    }
}