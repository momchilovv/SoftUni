using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());

        int totalHours = numberOfPages / pagesPerHour;

        Console.WriteLine(totalHours / numberOfDays);
    }
}