using System;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(15);
        Shape rectangle = new Rectangle(10, 5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
    }
}