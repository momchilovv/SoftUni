using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            foreach (var str in arr.Reverse())
            {
                Console.Write(string.Join(" ", str));
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}