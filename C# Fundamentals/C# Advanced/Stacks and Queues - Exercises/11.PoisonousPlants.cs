using System;
using System.Linq;
using System.Collections.Generic;

namespace _11.PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            int[] daysToDie = new int[n];

            for (int i = 1; i < n; i++)
            {
                int days = 0;
                while (stack.Count != 0 && plants[stack.Peek()] >= plants[i])
                {
                    days = Math.Max(days, daysToDie[stack.Pop()]);
                }
                if (stack.Count != 0)
                {
                    daysToDie[i] = days + 1;
                }
                stack.Push(i);
            }
            Console.WriteLine(daysToDie.Max());
        }
    }
}