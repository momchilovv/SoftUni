using System;

class Program
{
    static void Main(string[] args)
    {
        double firstX1 = double.Parse(Console.ReadLine());
        double firstY1 = double.Parse(Console.ReadLine());
        double firstX2 = double.Parse(Console.ReadLine());
        double firstY2 = double.Parse(Console.ReadLine()); 
       
        double secondX1 = double.Parse(Console.ReadLine());
        double secondY1 = double.Parse(Console.ReadLine());
        double secondX2 = double.Parse(Console.ReadLine());
        double secondY2 = double.Parse(Console.ReadLine());

        double firstLine = CalculateLine(firstX1, firstY1, firstX2, firstY2);
        double secondLine = CalculateLine(secondX1, secondY1, secondX2, secondY2);

        if (firstLine >= secondLine)
        {
            ClosestToCenterPoint(firstX1, firstY1, firstX2, firstY2);
        }
        else
        {
            ClosestToCenterPoint(secondX1, secondY1, secondX2, secondY2);
        }
    }
    public static void ClosestToCenterPoint(double x1, double y1, double x2, double y2)
    {
        if ((x1 * x1) + (y1 * y1) <= (x2 * x2) + (y2 * y2))
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
    public static double CalculateLine(double x1, double y1, double x2, double y2)
    {
        return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
    }
}