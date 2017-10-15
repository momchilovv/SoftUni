using System;

namespace _03.PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double xOfPoint = double.Parse(Console.ReadLine());
            double yOfPoint = double.Parse(Console.ReadLine());

            if (x1 <= xOfPoint && x2 >= xOfPoint && y1 <= yOfPoint && y2 >= yOfPoint)
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Outside");
        }
    }
}