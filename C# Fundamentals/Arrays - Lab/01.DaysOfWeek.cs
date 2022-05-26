using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int day = int.Parse(Console.ReadLine());

        try
        {
            if (days.Contains(days[day - 1]))
            {
                Console.WriteLine(days[day - 1]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid day!");
        }
    }
}