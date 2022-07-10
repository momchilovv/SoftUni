using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        for (int i = int.Parse(firstNumber); i <= int.Parse(secondNumber); i++)
        {
            string currentNumber = i.ToString();

            int oddSum = 0;
            int evenSum = 0;

            for (int j = 0; j < currentNumber.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenSum += currentNumber[j];
                }
                else
                {
                    oddSum += currentNumber[j];
                }
            }

            if (evenSum == oddSum)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
