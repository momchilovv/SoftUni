using System;

class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        if (length <= 0)
        {
            Console.WriteLine("Length cannot be zero or negative.");
        }
        else if (width <= 0)
        {
            Console.WriteLine("Width cannot be zero or negative.");
        }
        else if (height <= 0)
        {
            Console.WriteLine("Height cannot be zero or negative");
        }
        else
        {
            Console.WriteLine($"Surface Area - {Calculation.SurfaceAreaCalculation(length, width, height):f2}");
            Console.WriteLine($"Lateral Surface Area - {Calculation.LateralSurfaceAreaCalculation(length, width, height):f2}");
            Console.WriteLine($"Volume - {Calculation.VolumeCalculation(length, width, height):f2}");
        }
    }
}