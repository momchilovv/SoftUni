using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            Console.WriteLine(stackOfStrings.IsEmpty());

            stackOfStrings.Push("First");
            stackOfStrings.Push("Second");
            stackOfStrings.Push("Third");

            var stack = new Stack<string>();

            stack.Push("Last");

            stackOfStrings.AddRange(stack);

            Console.WriteLine(string.Join(" ", stackOfStrings));
        }
    }
}