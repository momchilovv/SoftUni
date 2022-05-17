using System;

class Program
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int arrivalMinute = minute + 30;

        if (arrivalMinute >= 60)
        {
            hour++;
            arrivalMinute -= 60;
            if (hour >= 24)
                hour = 0;
        }
        if (arrivalMinute <= 9)
        {
            Console.WriteLine($"{hour}:0{arrivalMinute}");
        }
        else
        {
            Console.WriteLine($"{hour}:{arrivalMinute}");
        }
    }
}