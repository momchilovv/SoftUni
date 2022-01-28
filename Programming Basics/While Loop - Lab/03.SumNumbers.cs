using System;

class Program
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        double input = double.Parse(Console.ReadLine());

        double sum = 0;
        sum += input;
        while (sum <= number)
        {
            if (sum == number)
            {
                break;
            }
            input = double.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine(sum);
    }
}