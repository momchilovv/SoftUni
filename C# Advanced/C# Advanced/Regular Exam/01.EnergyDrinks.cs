using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var caffeine = new Stack<int>(Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));

        var energyDrinks = new Queue<int>(Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));

        int stamatCaffeine = 0;

        while (true)
        {
            if (energyDrinks.Count <= 0 || caffeine.Count <= 0)
            {
                break;
            }

            int result = caffeine.Pop() * energyDrinks.Peek();

            if (result + stamatCaffeine > 300)
            {
                if (stamatCaffeine >= 30)
                {
                    stamatCaffeine -= 30;
                }

                var temp = energyDrinks.Dequeue();
                energyDrinks.Enqueue(temp);
            }
            else
            {
                stamatCaffeine += result;
                energyDrinks.Dequeue();
            }
        }

        if (energyDrinks.Count == 0)
        {
            Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
        }
        else
        {
            Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
        }

        Console.WriteLine($"Stamat is going to sleep with {stamatCaffeine} mg caffeine.");
    }
}