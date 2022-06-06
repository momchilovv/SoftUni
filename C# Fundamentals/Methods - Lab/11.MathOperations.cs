using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculate(firstNumber, secondNumber, operation));
    }
    public static double Calculate(int firstNumber, int secondNumber, string operation)
    {
        switch (operation)
        {
            case "*":
                return firstNumber * secondNumber;
            case "/":
                return firstNumber / secondNumber;
            case "-":
                return firstNumber - secondNumber;
            default:
                return firstNumber + secondNumber;
        }
    }
}