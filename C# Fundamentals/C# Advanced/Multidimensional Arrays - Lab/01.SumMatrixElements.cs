using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        decimal ivanchoCash = decimal.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        double priceForBanana = double.Parse(Console.ReadLine());
        double priceForEgg = double.Parse(Console.ReadLine());
        double priceForBerries = double.Parse(Console.ReadLine());

        int portions = Math.Ceiling(numberOfGuests / 6.0);

        decimal totalPrice = (portions * priceForBanana * 2) + (portions * priceForEgg * 4) + portions * priceForEgg * 0.2m;

        if (ivanchoCash >= totalPrice)
        {
            totalPrice = ivanchoCash - totalPrice;
            Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice}lv.”");
        }
        else
        {
            totalPrice = totalPrice - ivanchoCash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice}lv more.”");
        }
    }
}