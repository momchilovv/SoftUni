using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);

            Console.WriteLine(string.Join(Environment.NewLine, numbers.Select(x => $"{x * 1.20:f2}")));
        }
    }
}