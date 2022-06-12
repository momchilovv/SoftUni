using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(SubtractTheThirdNumber(SumFirstTwoNumbers(firstNumber,secondNumber), thirdNumber));
    }
    public static int SumFirstTwoNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
    public static int SubtractTheThirdNumber(int sumOfTwoNumbers, int thirdNumber)
    {
        return sumOfTwoNumbers - thirdNumber;
    }
}