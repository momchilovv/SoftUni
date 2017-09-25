using System;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggerOne = 0;
            int smallerOne = 0;

            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            if (firstInput > secondInput)
            {
                biggerOne = firstInput;
                smallerOne = secondInput;
            }
            else if (firstInput < secondInput)
            {
                biggerOne = secondInput;
                smallerOne = firstInput;
            }
            for (int i = smallerOne; i <= biggerOne; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}