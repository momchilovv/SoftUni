using System;

class Program
{
    static void Main(string[] args)
    {
        int annualTax = int.Parse(Console.ReadLine());

        double sneakersPrice = annualTax - (annualTax * 0.4);
        double outfitPrice = sneakersPrice - (sneakersPrice * 0.2);
        double ballPrice = outfitPrice / 4;
        double accessories = ballPrice / 5;

        double totalSum = annualTax + sneakersPrice + outfitPrice + ballPrice + accessories;

        Console.WriteLine(totalSum);
    }
}