using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double side = 0;
            double height = 0;
            double width = 0;
            double radius = 0;

            switch (figure)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(side * height) / 2:f2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * side:f2}");
                    break;
                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{width * height:f2}");
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI * radius * radius:f2}");
                    break;
            }
        }
    }
}