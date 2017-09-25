using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100 = double.Parse(Console.ReadLine());
            double sugarContentPer100 = double.Parse(Console.ReadLine());
            double sugarContent = sugarContentPer100 * volume / 100;
            double energyContent = energyContentPer100 * volume / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
