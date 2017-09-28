using System;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double totalBars = numberOfBeats / 4.0;

            double second = numberOfBeats * 60 / beatsPerMinute;

            int minutes = (int)second / 60;

            int seconds = (int)second - (minutes * 60);
            Console.WriteLine($"{Math.Round(totalBars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}