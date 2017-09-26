using System;

class Program
{
    static void Main()
    {
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        int b = Math.Abs(int.Parse(Console.ReadLine()));
        int magicNumber = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = 0;
        int totalCombinations = 0;
        bool isMagicNumber = false;


        for (int i = a; i >= 1; i--)
        {
            for (int j = 1; j <= b; j++)
            {
                if (sum >= magicNumber)
                {
                    isMagicNumber = true;
                    break;
                }
                else
                {
                    totalCombinations++;
                    sum += 3 * (i * j);
                }
            }
            if (sum >= magicNumber)
            {
                isMagicNumber = true;
                break;
            }
        }
        Console.WriteLine("{0} combinations", totalCombinations);
        if (isMagicNumber)
        {
            Console.WriteLine("Sum: {0} >= {1}", sum, magicNumber);
        }
        else
        {
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}