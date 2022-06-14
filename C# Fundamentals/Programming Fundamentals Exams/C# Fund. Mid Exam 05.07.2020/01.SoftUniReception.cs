using System;

class Program
{
    static void Main(string[] args)
    {
        int firstEm = int.Parse(Console.ReadLine());
        int secondEm = int.Parse(Console.ReadLine());
        int thirdEm = int.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());

        int efficiency = firstEm + secondEm + thirdEm;

        int breakCount = 0, currentTime = 0;

        while (studentsCount > 0)
        {
            breakCount++;
            if (breakCount == 4)
            {
                currentTime++;
                breakCount = 0;
                continue;
            }
            currentTime++;
            studentsCount -= efficiency;
        }
        Console.WriteLine($"Time needed: {currentTime}h.");
    }
}