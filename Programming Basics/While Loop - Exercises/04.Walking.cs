using System;
class Program
{
    static void Main(string[] args)
    {
        string steps = null;
        int walkedSteps = 0;

        while (walkedSteps < 10000)
        {
            steps = Console.ReadLine();

            if (steps == "Going home")
            {
                walkedSteps += int.Parse(Console.ReadLine());
                break;
            }
            if (walkedSteps >= 10000)
            {
                GoalReached(walkedSteps);
                System.Environment.Exit(0);
            }
            walkedSteps += int.Parse(steps);
        }
        if (walkedSteps >= 10000)
        {
            GoalReached(walkedSteps);
        }
        else
        {
            Console.WriteLine($"{10000 - walkedSteps} more steps to reach goal.");
        }
    }
    static void GoalReached(int walkedSteps)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{walkedSteps - 10000} steps over the goal!");
    }
}