using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int numberOfSnowballs = int.Parse(Console.ReadLine());

        BigInteger highestSnow = 0, highestTime = 0, highestQuality = 0, highestValue = 0;

        for (int i = 1; i <= numberOfSnowballs; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue >= highestValue)
            {
                highestValue = snowballValue;
                highestSnow = snowballSnow;
                highestTime = snowballTime;
                highestQuality = snowballQuality;
            }
        }
        Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
    }
}