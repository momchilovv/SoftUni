using System;

class Program
{
    static void Main(string[] args)
    {
        string actorName = Console.ReadLine();
        double points = double.Parse(Console.ReadLine());
        int graders = int.Parse(Console.ReadLine());

        for (int i = 0; i < graders; i++)
        {
            string graderName = Console.ReadLine();
            double graderPoints = double.Parse(Console.ReadLine());

            if (points < 1250.5)
            {
                points += (graderPoints * graderName.Length) / 2;
            }
        }
        if (points < 1250.50)
        {
            Console.WriteLine($"Sorry, {actorName} you need {1250.50 - points:f1} more!");
        }
        else if (points >= 1250.50)
        {
            Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        }
    }
}