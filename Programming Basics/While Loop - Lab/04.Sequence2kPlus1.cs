using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int currentNumber = 1;
        int nextNumber = 0;

        while (number >= nextNumber)
        {
            Console.WriteLine(currentNumber);
            if (number == nextNumber)
                break;
            nextNumber = currentNumber * 2 + 1;
            currentNumber = nextNumber;           
        }
    }
}