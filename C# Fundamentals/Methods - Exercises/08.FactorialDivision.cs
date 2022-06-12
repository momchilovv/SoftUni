using System;

class Program
{
    static void Main(string[] args)
    {
        CalculateFactorial(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    }
    public static void CalculateFactorial(double firstNumber, double secondNumber)
    {
        double firstResult = 1, secondResult = 1;

        for (int i = 1; i <= firstNumber; i++)
        {
            firstResult *= i;
        }
        for (int i = 1; i <= secondNumber; i++)
        {
            secondResult *= i;
        }
        Console.WriteLine($"{Math.Abs(firstResult / secondResult):f2}");
    }
}