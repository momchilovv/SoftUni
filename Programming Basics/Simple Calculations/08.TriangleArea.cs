using System;

namespace _08.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a * h) / 2;

            Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");
        }
    }
}