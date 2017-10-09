using System;

namespace _02.MaxMethod
{
    class Program
    {
        static void GetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            GetMax();
        }
    }
}