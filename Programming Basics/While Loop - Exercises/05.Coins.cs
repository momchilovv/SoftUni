using System;

class Program
{
    static void Main(string[] args)
    {
        decimal amount = decimal.Parse(Console.ReadLine());
        int coinsChange = 0;

        while (amount > 0)
        {
            if (amount >= 2)
            {
                amount -= 2;
                coinsChange++;
            }
            else if (amount >= 1 && amount <= 1.99m)
            {
                amount -= 1;
                coinsChange++;
            }
            else if (amount >= 0.50m && amount <= 0.99m)
            {
                amount -= 0.50m;
                coinsChange++;
            }
            else if (amount >= 0.20m && amount <= 0.49m)
            {
                amount -= 0.20m;
                coinsChange++;
            }
            else if (amount >= 0.10m && amount <= 0.199m)
            {
                amount -= 0.10m;
                coinsChange++;
            }
            else if (amount >= 0.05m && amount <= 0.099m)
            {
                amount -= 0.05m;
                coinsChange++;
            }
            else if (amount >= 0.02m && amount <= 0.049m)
            {
                amount -= 0.02m;
                coinsChange++;
            }
            else 
            {
                amount -= 0.01m;
                coinsChange++;
            }
        }
        Console.WriteLine(coinsChange);
    }
}