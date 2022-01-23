using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double leftSum = 0;
        double rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            leftSum += double.Parse(Console.ReadLine());
        }
        for (int j = 0; j < n; j++)
        {
            rightSum += double.Parse(Console.ReadLine());
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}