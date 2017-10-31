using System;
using System.Numerics;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger result = first + second;
            Console.WriteLine(result);
        }
    }
}