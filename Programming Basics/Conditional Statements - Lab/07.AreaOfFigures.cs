using System;

class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(side * side):f3}");
        }
        else if (figure == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(sideA * sideB):f3}");
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(Math.PI * radius * radius):f3}");
        }
        else if (figure == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{((side * height) / 2):f3}");
        }
    }
}