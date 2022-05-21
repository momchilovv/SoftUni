using System;

class Program
{
    static void Main(string[] args)
    {
        int startYield = int.Parse(Console.ReadLine());
        int daysMined = 0;
        int totalMined = 0;

        while (startYield >= 100)
        {
            totalMined += startYield - 26;
            startYield -= 10;
            daysMined++;
        }
        if (totalMined >= 26)
        {
            totalMined -= 26;
        }

        Console.WriteLine(daysMined);
        Console.WriteLine(totalMined);
    }
}