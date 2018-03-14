using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point topLeftPoint = new Point(coordinates[0], coordinates[1]);
        Point bottomRightPoint = new Point(coordinates[2], coordinates[3]);

        Rectangle rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] inputPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point(inputPoint[0], inputPoint[1]);

            Console.WriteLine(rectangle.Contains(point));
        }
    }
}