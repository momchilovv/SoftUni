using System;
using System.Linq;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void PrintReversedNumber()
        {
            string number = Console.ReadLine();
            string revNumber = string.Join("", number.Reverse());

            Console.WriteLine(revNumber);
        }
        static void Main(string[] args)
        {
            PrintReversedNumber();
        }
    }
}