using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] baseN = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger n = baseN[0];
            BigInteger ten = baseN[1];
            BigInteger remain;

            string result = null;
            if (n >= 2 && n <= 10)
            {
                while (ten > 0)
                {
                    remain = ten % n;
                    ten *= n;
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