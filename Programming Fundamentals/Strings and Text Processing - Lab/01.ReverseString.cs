using System;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var each = input.ToCharArray();

            foreach (var e in each.Reverse())
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }
    }
}