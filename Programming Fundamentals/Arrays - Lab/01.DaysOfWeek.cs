using System;

namespace _01.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] days = {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
                };

                int dayN = int.Parse(Console.ReadLine());

                Console.WriteLine($"{days[dayN - 1]}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}