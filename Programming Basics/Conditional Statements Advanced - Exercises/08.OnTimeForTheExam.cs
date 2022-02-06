using System;

class Program
{
    static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        TimeSpan examTime = new TimeSpan(examHour, examMinute, 0);
        TimeSpan arrivalTime = new TimeSpan(arrivalHour, arrivalMinute, 0);

        TimeSpan value = examTime.Subtract(arrivalTime);


        if (examTime == arrivalTime)
        {
            Console.WriteLine("On time");
            return;
        }
        if (examTime.Hours == arrivalTime.Hours && value.Minutes >= 1 && value.Minutes <= 30
            || examTime.Hours == arrivalTime.Hours && value.Minutes >= 1 && value.Minutes <= 30 && value.Hours >= 1
            || examTime.Hours != arrivalTime.Hours && value.Minutes >= 1 && value.Minutes <= 30 && value.Hours < 1)
        {
            Console.WriteLine("On time");
            Console.WriteLine($"{Math.Abs(value.Minutes)} minutes before the start");
        }
        else if (examTime.Hours == arrivalTime.Hours && value.Minutes > 30 && value.Minutes <= 59
            || examTime.Hours == arrivalTime.Hours && value.Minutes > 30 && value.Minutes <= 59 && value.Hours <= 1
            || examTime.Hours != arrivalTime.Hours && value.Minutes > 30 && value.Minutes <= 59 && value.Hours <= 1)
        {
            if (value.Hours >= 1)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Abs(value.Hours)}:{Math.Abs(value.Minutes):00} hours before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Abs(value.Minutes)} minutes before the start");
            }
        }
        else if (examTime.Hours != arrivalTime.Hours && value.Hours >= 1)
        {
            Console.WriteLine("Early");
            Console.WriteLine($"{Math.Abs(value.Hours)}:{Math.Abs(value.Minutes):00} hours before the start");
        }
        else if (examTime.Hours == arrivalTime.Hours && arrivalTime.Minutes >= 1 && value.Minutes <= 59
            || examTime.Hours <= arrivalTime.Hours && value.Minutes >= 1 && value.Minutes <= 59
            || examTime.Minutes < arrivalTime.Minutes && value.Minutes >= 1 && value.Minutes <= 59)
        {
            Console.WriteLine("Late");
            Console.WriteLine($"{Math.Abs(value.Minutes)} minutes after the start");
        }
        else
        {
            Console.WriteLine("Late");
            if (value.Hours >= 1)
            {
                Console.WriteLine($"{Math.Abs(value.Minutes):00} minutes after the start");
            }
            else
            {
                if (value.Hours == 0)
                    Console.WriteLine($"{Math.Abs(value.Minutes):00} minutes after the start");
                else
                    Console.WriteLine($"{Math.Abs(value.Hours)}:{Math.Abs(value.Minutes):00} hours after the start");
            }
        }
    }
}