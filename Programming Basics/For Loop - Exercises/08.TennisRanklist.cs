using System;

class Program
{
    static void Main(string[] args)
    {
        double tournaments = double.Parse(Console.ReadLine());
        double ranklistPoints = double.Parse(Console.ReadLine());
        double startPoints = ranklistPoints;
        double wonCount = 0;

        for (int i = 0; i < tournaments; i++)
        {
            string placement = Console.ReadLine();
            
            if (placement == "W")
            {
                ranklistPoints += 2000;
                wonCount++;
            }
            else if (placement == "F")
            {
                ranklistPoints += 1200;
            }
            else if (placement == "SF")
            {
                ranklistPoints += 720; 
            }
        }
        Console.WriteLine($"Final points: {ranklistPoints}");
        Console.WriteLine($"Average points: {Math.Floor((ranklistPoints - startPoints) / tournaments):f0}");
        Console.WriteLine($"{wonCount / tournaments * 100:f2}%");
    }
}