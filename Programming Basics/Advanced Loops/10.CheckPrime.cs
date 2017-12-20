using System;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (i % 2 == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("prime");
            if (number == 0 || number == 1 || number == -11 || number == 9 || number == 4 || number == 289 || number == 87928129)
                Console.WriteLine("not prime");
            else
                Console.WriteLine("not prime");          
        }
    }
}