using System;

class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine($"Surface Area - {Calculation.SurfaceAreaCalculation(length, width, height):f2}");
        Console.WriteLine($"Lateral Surface Area - {Calculation.LateralSurfaceAreaCalculation(length, width, height):f2}");
        Console.WriteLine($"Volume - {Calculation.VolumeCalculation(length, width, height):f2}");
    }
}