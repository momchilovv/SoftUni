using System;

class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = 0;

        for (int i = 0; i < numbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;

            if (number > max)
                max = number;     
        }
        if ((sum - max) == max)
            Console.WriteLine("Yes\r\n" +
                $"Sum = {sum - max}");
        else
            Console.WriteLine("No\r\n" +
                $"Diff = {Math.Abs(max - (sum - max))}");
    }
}