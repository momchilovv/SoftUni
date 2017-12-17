using System;

namespace _14.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int minuteAfter = minute + 15;

            if (hour >= 0 && hour <= 24 && minuteAfter >= 60)
            {
                hour++;
                if (hour == 24)
                    hour = 0;
                minute = minuteAfter % 60;
                Console.WriteLine($"{hour:d}:{minute:d2}");
            }
            else
            {
                minute = minuteAfter % 60;
                Console.WriteLine($"{hour:d}:{minute:d2}");
            }
        }
    }
}