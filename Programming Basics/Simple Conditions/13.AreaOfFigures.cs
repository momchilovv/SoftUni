using System;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.Round(length * length, 3)}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.Round(a * b, 3)}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.Round(Math.PI * radius * radius, 3)}");
            }
            else if (figure == "triangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.Round((width * height) / 2, 3)}");
            }
        }
    }
}