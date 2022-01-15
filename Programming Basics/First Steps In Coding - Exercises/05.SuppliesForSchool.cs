using System;

class Program
{
    static void Main(string[] args)
    {
        int penPackCount = int.Parse(Console.ReadLine());
        int markerPackCount = int.Parse(Console.ReadLine());
        int deskCleaner = int.Parse(Console.ReadLine());
        int discountPercent = int.Parse(Console.ReadLine());

        double total = (penPackCount * 5.80) + (markerPackCount * 7.20) + (deskCleaner * 1.20);

        Console.WriteLine(total - ((total * discountPercent) / 100));
    }
}