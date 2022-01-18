using System;

class Program
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());

        minute += 15;

        if (hour > 23 || minute > 59)
        {
            
            hour += 1;
            minute -= 60;
        }
        if (hour == 24)
        {
            hour -= 24;
        }
        if (minute < 10)
        {
            Console.WriteLine($"{hour}:0{minute}");
        }
        else
        {
            Console.WriteLine($"{hour}:{minute}");
        }
    }
}