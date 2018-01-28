using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            for (int i = 2; i <= count; i++)
            {
                long first = stack.Pop();
                long second = stack.Pop();
                stack.Push(first);
                stack.Push(first + second);
            }
            Console.WriteLine(stack.Pop());
        }
    }
}