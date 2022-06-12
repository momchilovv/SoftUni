using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        CheckResult(firstNumber, secondNumber, thirdNumber);
    }
    public static void CheckResult(int firstNumber, int secondNumber, int thirdNumber)
    {
        bool isZero = false;
        int negativeCount = 0;
        int[] array = new int[3] { firstNumber, secondNumber, thirdNumber };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negativeCount++;
            }
            else if (array[i] == 0)
            {
                isZero = true;
            }
        }
        if (negativeCount % 2 == 1)
        {
            Console.WriteLine("negative");
        }
        else if (isZero)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }
}