using System;

class Program
{
    static void Main(string[] args)
    {
        int paper = int.Parse(Console.ReadLine());
        int fabric = int.Parse(Console.ReadLine());
        double glue = double.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double allMaterials = (paper * 5.80) + (fabric * 7.20) + (glue * 1.20);

        Console.WriteLine($"{(allMaterials - (allMaterials * discount) / 100):f3}");
    }
}