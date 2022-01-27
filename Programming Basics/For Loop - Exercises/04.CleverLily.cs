using System;

class Program
{
    static void Main(string[] args)
    {
        int lilyAge = int.Parse(Console.ReadLine());
        double washPrice = double.Parse(Console.ReadLine());
        double pricePerToy = double.Parse(Console.ReadLine());

        double lilySavings = 0;
        double moneyPerYear = 9;

        for (int i = 1; i <= lilyAge; i++)
        {
            if (i % 2 == 0)
            {
                lilySavings += moneyPerYear;
                moneyPerYear += 10;
            }
            else
            {
                lilySavings += pricePerToy;
            }
        }
        if (lilySavings >= washPrice)
        {
            Console.WriteLine($"Yes! {lilySavings - washPrice:f2}");
        }
        else
        {
            Console.WriteLine($"No! {washPrice - lilySavings:f2}");
        }
    }
}