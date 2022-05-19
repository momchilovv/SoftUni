using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case int divided when (number % 10 == 0):
                Console.WriteLine("The number is divisible by 10");
                break;
            case int divided when (number % 7 == 0):
                Console.WriteLine("The number is divisible by 7");
                break;
            case int divided when (number % 6 == 0):
                Console.WriteLine("The number is divisible by 6");
                break;
            case int divided when (number % 3 == 0):
                Console.WriteLine("The number is divisible by 3");
                break;
            case int divided when (number % 2 == 0):
                Console.WriteLine("The number is divisible by 2");
                break;
            default:
                Console.WriteLine("Not divisible");
                break;
        }
    }
}