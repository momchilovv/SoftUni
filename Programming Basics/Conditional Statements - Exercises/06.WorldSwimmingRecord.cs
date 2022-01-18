using System;

class Program
{
    static void Main(string[] args)
    {
        double worldRecord = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());

        double addedTime = (Math.Floor(distance / 15)) * 12.5;
        double swimmed = distance * time;

        double finalTime = addedTime + swimmed;

        if (finalTime >= worldRecord)
        {
            Console.WriteLine($"No, he failed! He was {finalTime - worldRecord:f2} seconds slower.");
        }
        else
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
        }
    }
}