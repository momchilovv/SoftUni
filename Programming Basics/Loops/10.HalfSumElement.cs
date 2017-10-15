using System;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int greatestNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > greatestNumber)
                {
                    if (greatestNumber != int.MinValue)
                        sum += greatestNumber;

                    greatestNumber = currentNumber;
                }
                else
                    sum += currentNumber;

            }
            if (sum == greatestNumber)
                Console.WriteLine($"Yes Sum = {sum}");
            else
                Console.WriteLine($"No Diff = {Math.Abs(sum - greatestNumber)}");            
        }
    }
}