using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (var number in numbers)
        {
            Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(Math.Round(number, MidpointRounding.AwayFromZero))}");
        }
    }
}