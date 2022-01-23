using System;

class Program
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());

        double result;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - even");
                else
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - odd");
                break;
            case '-':
                result = firstNumber - secondNumber;
                if (result % 2 == 0)
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - even");
                else
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - odd");
                break;
            case '*':
                result = firstNumber * secondNumber;
                if (result % 2 == 0)
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - even");
                else
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - odd");
                break;
            case '/':
                result = firstNumber / secondNumber;
                if (secondNumber == 0)
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                else
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");               
                break;
            case '%':
                result = firstNumber % secondNumber;
                if (secondNumber == 0)
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                else
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                break;
        }
    }
}