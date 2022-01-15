using System;

class Program
{
    static void Main(string[] args)
    {
        double sMeters = double.Parse(Console.ReadLine());
        double fullPrice = 7.61 * sMeters;
        double discount = fullPrice * 0.18;

        Console.WriteLine($"The final price is: {fullPrice - discount} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}