using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int toss = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}