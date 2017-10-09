using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void PrintPrimesInRange(List<int> list)
        {
            Console.WriteLine(string.Join(", ", list.ToArray()));
        }
        static List<int> FindPrimesInRange(int start, int end)
        {
            var list = new List<int>();
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                    list.Add(number);
                else
                    continue;
            }
            return list;
        }
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> list = FindPrimesInRange(start, end);
            PrintPrimesInRange(list);
        }
    }
}