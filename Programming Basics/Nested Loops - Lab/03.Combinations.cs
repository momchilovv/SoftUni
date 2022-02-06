using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j <= number; j++)
            {
                for (int k = 0; k <= number; k++)
                {
                    if (i + j + k == number)
                        count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}