using System;

class Program
{
    static void Main(string[] args)
    {
        int chickenMenu = int.Parse(Console.ReadLine());
        int fishMenu = int.Parse(Console.ReadLine());
        int veggieMenu = int.Parse(Console.ReadLine());

        double chickenMenuSum = chickenMenu * 10.35;
        double fishMenuSum = fishMenu * 12.40;
        double veggieMenuSum = veggieMenu * 8.15;
        double totalMenuSum = chickenMenuSum + fishMenuSum + veggieMenuSum;

        double desertPrice = totalMenuSum * 0.2;

        double totalSum = totalMenuSum + desertPrice + 2.50;

        Console.WriteLine(totalSum);
    }
}