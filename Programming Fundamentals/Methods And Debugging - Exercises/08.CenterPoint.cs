using System;
using System.Collections.Generic;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstDistance = PrintClosePoint(x1, y1);
            double secondDistance = PrintClosePoint(x2, y2);

            var list = new List<double>(2);

            if (firstDistance > secondDistance)
            {
                list.Add(x2);
                list.Add(y2);
            }
            else
            {
                list.Add(x1);
                list.Add(y1);
            }

            Console.Write("(");
            Console.Write(string.Join(", ", list));
            Console.WriteLine(")");
        }
        static double PrintClosePoint(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}