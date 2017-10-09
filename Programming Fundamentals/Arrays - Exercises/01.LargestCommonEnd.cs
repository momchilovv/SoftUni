using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void LargestCommonEndRight(string[] first, string[] second)
        {
            var rCount = 0;
            var lCount = 0;

            while (rCount < first.Length && rCount < second.Length)
            {
                if (first[first.Length - rCount - 1] == second[second.Length - rCount - 1])
                    rCount++;

                else break;

            }
            while (lCount < first.Length && lCount < second.Length)
            {
                if (first[lCount] == second[lCount])
                    lCount++;

                else break;
            }
            if (rCount > lCount)
                Console.WriteLine(rCount);

            else
                Console.WriteLine(lCount);
        }
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').ToArray();
            var second = Console.ReadLine().Split(' ').ToArray();

            LargestCommonEndRight(first, second);
        }
    }
}