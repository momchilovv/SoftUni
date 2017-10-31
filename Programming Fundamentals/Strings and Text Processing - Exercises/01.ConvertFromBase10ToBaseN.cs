using System;
using System.Linq;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] base10 = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger n = base10[0];
            BigInteger ten = base10[1];
            BigInteger remain;

            string result = null;
            if (n >= 2 && n <= 10)
            {
                while (ten > 0)
                {
                    remain = ten % n;
                    ten /= n;
                    result = remain.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}