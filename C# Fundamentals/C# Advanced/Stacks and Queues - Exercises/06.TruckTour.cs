using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<long[]> queue = new Queue<long[]>();
            long fuel = 0;

            for (int i = 0; i < petrolPumps; i++)
            {
                queue.Enqueue(Console.ReadLine().Split().Select(long.Parse).ToArray());
            }
            for (int i = 0; i < petrolPumps; i++)
            {
                long[] current = queue.Peek();
                bool isFuelEnough = true;
                for (int j = 0; j < queue.Count; j++)
                {
                    fuel += current[0];
                    if (fuel < current[1])
                    {
                        isFuelEnough = false;

                        for (int k = queue.Count - j + 1; k > 0; k--)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                        break;
                    }
                    fuel -= current[1];
                    queue.Enqueue(queue.Dequeue());
                    current = queue.Peek();
                }
                if (isFuelEnough)
                {
                    Console.WriteLine(i);
                    return;
                }
                fuel = 0;
            }
        }
    }
}