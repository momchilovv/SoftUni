using System;
using System.Numerics;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger integer;
            float floatingPoint;
            bool isBool;
            char ch;

            while (input != "END")
            {
                if (BigInteger.TryParse(input, out integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatingPoint))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out isBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out ch))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
