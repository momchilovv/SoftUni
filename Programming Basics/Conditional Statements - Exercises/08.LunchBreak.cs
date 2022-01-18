using System;

class Program
{
    static void Main(string[] args)
    {
        string seriesName = Console.ReadLine();
        double episodeLength = double.Parse(Console.ReadLine());
        double breakLength = double.Parse(Console.ReadLine());

        double lunchTime = breakLength / 8;
        double relaxTime = breakLength / 4;

        double timeLeft = breakLength - (lunchTime + relaxTime);

        if (timeLeft >= episodeLength)
        {
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
        }
        else
        {
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLength - timeLeft)} more minutes.");
        }
    }
}