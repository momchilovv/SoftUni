using System;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int XRepetingTimes = int.Parse(Console.ReadLine());

            for (int i = -(XRepetingTimes / 2); i <= XRepetingTimes / 2; i++)
            {
                if (i == 0)
                {
                   Console.WriteLine("{0}x", new string(' ', XRepetingTimes / 2));
                }
                else
                {
                   Console.WriteLine("{0}x{1}x",
                   new string(' ', Math.Abs(XRepetingTimes / 2 - Math.Abs(i))),
                   new string(' ', Math.Abs(i * 2) - 1));
                }
            }
        }
    }
}