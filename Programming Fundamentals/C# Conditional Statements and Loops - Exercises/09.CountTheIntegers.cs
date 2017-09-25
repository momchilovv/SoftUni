using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCount = 0;

            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    iCount++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(iCount);
            }
        }
    }
}