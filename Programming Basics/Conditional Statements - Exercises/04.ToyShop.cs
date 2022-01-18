using System;

class Program
{
    static void Main(string[] args)
    {
        double vacationCost = double.Parse(Console.ReadLine());
        int jigsawCount = int.Parse(Console.ReadLine());
        int dollsCount = int.Parse(Console.ReadLine());
        int teddybearsCount = int.Parse(Console.ReadLine());
        int minionsCount = int.Parse(Console.ReadLine());
        int trucksCount = int.Parse(Console.ReadLine());

        double totalForToys = jigsawCount * 2.60 + dollsCount * 3 + teddybearsCount * 4.10 +
            minionsCount * 8.20 + trucksCount * 2;

        int toysCount = jigsawCount + dollsCount + teddybearsCount + minionsCount + trucksCount;

        double totalPrice = 0;

        if (toysCount >= 50)
        {
            totalPrice = totalForToys - (totalForToys * 0.25);
        }
        else
        {
            totalPrice = totalForToys;
        }

        totalPrice = totalPrice - (totalPrice * 0.10);

        if (totalPrice >= vacationCost)
        {
            Console.WriteLine($"Yes! {(totalPrice - vacationCost):f2} lv left.");
        }
        else if(totalPrice < vacationCost)
        {
            Console.WriteLine($"Not enough money! {((vacationCost - totalPrice)):f2} lv needed.");
        }
    }
}