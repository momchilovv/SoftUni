using System;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            double face = 0;
            double space = 0;
            double volume = 0;
            double area = 0;

            switch (str)
            {
                case "face":
                    face = Math.Sqrt(2 * (cubeSide * cubeSide));
                    Console.WriteLine($"{face:f2}");
                    break;
                case "space":
                    space = Math.Sqrt(3 * (cubeSide * cubeSide));
                    Console.WriteLine($"{space:f2}");
                    break;
                case "volume":
                    volume = (cubeSide * cubeSide * cubeSide);
                    Console.WriteLine($"{volume:f2}");
                    break;
                case "area":
                    area = 6 * (cubeSide * cubeSide);
                    Console.WriteLine($"{area:f2}");
                    break;
            }
        }
    }
}