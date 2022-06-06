using System;

class Program
{
    static void Main(string[] args)
    {
        string operation = Console.ReadLine();
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        Calculate(operation, firstNumber, secondNumber);
    }
    public static void Calculate(string operation, double firstNumber, double secondNumber)
    {
        switch (operation)
        {
            case "add":
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case "multiply":
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case "subtract":
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case "divide":
                Console.WriteLine(firstNumber / secondNumber);
                break;
        }
    }
}