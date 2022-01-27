using System;

class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());

        double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

        for (int i = 0; i < numbers; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 200)
            {
                p1++;
            }
            else if (number >= 200 && number <= 399)
            {
                p2++;
            }
            else if (number >= 400 && number <= 599)
            {
                p3++;
            }
            else if (number >= 600 && number <= 799)
            {
                p4++;
            }
            else if (number >= 800)
            {
                p5++;
            }
        }
        Console.WriteLine($"{(p1 / numbers) * 100:f2}%\r\n{(p2 / numbers) * 100:f2}%\r\n" +
            $"{(p3 / numbers) * 100:f2}%\r\n{(p4 / numbers) * 100:f2}%\r\n{(p5 / numbers) * 100:f2}%");
    }
}