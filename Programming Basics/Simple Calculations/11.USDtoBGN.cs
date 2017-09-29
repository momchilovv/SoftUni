using System;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double oneusd = 1.79549;

            Console.WriteLine($"{Math.Round((usd * oneusd), 2)} BGN");
        }
    }
}