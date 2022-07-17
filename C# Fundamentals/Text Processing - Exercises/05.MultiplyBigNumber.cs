using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine();
        int secondNumber = int.Parse(Console.ReadLine());

        int remainder = 0;

        if (secondNumber == 0)
        {
            Console.WriteLine(0);
            Environment.Exit(0);
        }

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            int sum = int.Parse(firstNumber[i].ToString()) * secondNumber + remainder;

            stringBuilder.Append(sum % 10);

            remainder = sum / 10;
        }

        if (remainder != 0)
        {
            stringBuilder.Append(remainder);
        }

        Console.WriteLine(string.Join("", stringBuilder.ToString().Reverse()));
    }
}