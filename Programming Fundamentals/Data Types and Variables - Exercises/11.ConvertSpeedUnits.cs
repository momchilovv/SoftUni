using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceM = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = (hours * 3600) + (minutes * 60) + seconds;
            
            float metersPerSeconds = distanceM / time;
            float kilometersPerHour = (distanceM / 1000) / (time / 3600);
            float milesPerHour = (distanceM / 1609) / (time / 3600);

            Console.WriteLine($"{metersPerSeconds:0.#######}");
            Console.WriteLine($"{kilometersPerHour:0.#######}");
            Console.WriteLine($"{milesPerHour:0.#######}");
        }
    }
}