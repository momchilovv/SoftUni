using System;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneMile = 1.60934;

            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"{input * oneMile:f2}");
        }
    }
}
