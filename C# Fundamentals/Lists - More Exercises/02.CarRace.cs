using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> raceTime = Console.ReadLine().Split().Select(int.Parse).ToList();

        double leftRacerTime = 0, rightRacerTime = 0;

        for (int i = 0; i < raceTime.Count / 2; i++)
        {
            if (raceTime[i] == 0)
            {
                leftRacerTime *= 0.8;
            }
            else
            {
                leftRacerTime += raceTime[i];
            }
        }
        for (int i = raceTime.Count - 1; i > raceTime.Count / 2; i--)
        {
            if (raceTime[i] == 0)
            {
                rightRacerTime *= 0.8;
            }
            else
            {
                rightRacerTime += raceTime[i];
            }
        }
        if (leftRacerTime < rightRacerTime)
        {
            Console.WriteLine($"The winner is left with total time: {leftRacerTime}"); 
        }
        else 
        {
            Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
        }
    }
}