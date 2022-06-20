using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int queue = int.Parse(Console.ReadLine());
        int[] liftState = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int capacity = (liftState.Length * 4) - liftState.Sum();

        for (int i = 0; i < liftState.Length; i++)
        {
            int max = 4 - liftState[i];
            if (max > 0 && queue > 0 && capacity > 0)
            {
                for (int j = 0; j < max; j++)
                {
                    liftState[i]++;
                    queue--;
                    capacity--;
                    if (queue == 0 || capacity == 0)
                    {
                        break;
                    }
                }
            }
        }
        if (queue == 0 && capacity > 0)
        {
            Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ", liftState));
        }
        else if (queue > 0)
        {
            Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
            Console.WriteLine(string.Join(" ", liftState));
        }
        else if (queue == 0 && capacity == 0)
        {
            Console.WriteLine(string.Join(" ", liftState));
        }
    }
}