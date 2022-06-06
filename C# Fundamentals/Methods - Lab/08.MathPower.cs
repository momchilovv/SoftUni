using System;

class Program
{
    static void Main(string[] args)
    {
        double baseNumber = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        Console.WriteLine(Power(baseNumber, power));
    }
    public static double Power(double baseNumber, double power)
    {
        return Math.Pow(baseNumber, power);
    }
}