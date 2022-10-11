using System;
using System.Collections.Generic;

namespace CustomLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Linked List using string
            LinkedList<string> stringList = new LinkedList<string>();

            Action<string> print = n => Console.WriteLine(n);

            stringList.AddFirst("is string");
            stringList.AddFirst("This");
            stringList.AddLast("list.");

            Console.WriteLine($"{stringList.GetType()}:");
            stringList.ForEach(print);
            Console.WriteLine();
            
            //Linked List using integer
            LinkedList<int> intList = new LinkedList<int>();

            intList.AddFirst(1);
            intList.AddLast(2);
            intList.AddLast(3);

            Console.WriteLine($"{intList.GetType()}:");
            intList.ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            //Nested Linked List using List of string
            LinkedList<List<string>> nestedList = new LinkedList<List<string>>();

            var firstList = new List<string>()
            {
                "This is the first message from the first nested list"
            };

            var secondList = new List<string>()
            {
                "This is the first message from the second nested list"
            };

            var thirdList = new List<string>()
            {
                "This is the first message from the third nested list"
            };

            nestedList.AddLast(firstList);
            nestedList.AddLast(secondList);
            nestedList.AddLast(thirdList);

            Console.WriteLine($"{nestedList.GetType()}:");
            nestedList.ForEach(n => Console.WriteLine(String.Join(Environment.NewLine, n)));
        }
    }
}