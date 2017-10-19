using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoints(Console.ReadLine());
            Point p2 = ReadPoints(Console.ReadLine());

            Console.WriteLine($"{CalcPointDistance(p1, p2):f3}");
        }
        static Point ReadPoints(string input)
        {
            double[] coordinates = input.Split().Select(double.Parse).ToArray();
            return new Point() { X = coordinates[0], Y = coordinates[1] };
        }
        static double CalcPointDistance(Point p1, Point p2)
        {
            double x = p1.X - p2.X;
            double y = p1.Y - p2.Y;
            double result = Math.Sqrt((x * x) + (y * y));

            return result;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}