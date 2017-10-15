using System;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalSeconds = first + second + third;
            int minutes = 0;

            if (totalSeconds <= 59)
            {
                minutes = 0; totalSeconds = first + second + third;
            }
            else if ((totalSeconds > 59) && (totalSeconds <= 119))
            {
                minutes++; totalSeconds = totalSeconds - 60;
            }
            else if ((totalSeconds > 119) && (totalSeconds <= 179))
            {
                minutes += 2; totalSeconds = totalSeconds - 120;
            }
            if (totalSeconds < 10)
            {
                Console.WriteLine($"{minutes}:0{totalSeconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{totalSeconds}");
            }
        }
    }
}