using System;

class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int firstSub = 0;
        int secondSub = 0;
        int count = 0;

        for (int g = k; g <= 8; g++)
        {
            for (int h = 9; h >= l; h--)
            {
                for (int i = m; i <= 8; i++)
                {
                    for (int j = 9; j >= n; j--)
                    {
                        if (g % 2 == 0 && h % 2 != 0 && i % 2 == 0 && j % 2 != 0)
                        {
                            firstSub = g * 10 + h;
                            secondSub = i * 10 + j;

                            if (firstSub != secondSub)
                            {
                                Console.WriteLine($"{g}{h} - {i}{j}");
                                count++;
                                if (count >= 6)
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                        }
                    }
                }
            }
        }
    }
}