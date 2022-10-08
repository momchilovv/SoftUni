using System;

namespace LinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Action<int> print = n => Console.WriteLine(n);

            Console.WriteLine("Adding to the beginning:");
            
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            list.ForEach(print);
            //Return:
            //       3
            //       2
            //       1

            Console.WriteLine("Adding to the end:");
            list.AddLast(4);
            list.AddLast(5);

            list.ForEach(print);
            //Return:
            //       3
            //       2
            //       1
            //       4
            //       5

            Console.WriteLine("Removing the first element:");
            list.RemoveFirst();

            list.ForEach(print);
            //Return:
            //       2
            //       1
            //       4
            //       5

            Console.WriteLine("Removing the last element:");
            list.RemoveLast();

            list.ForEach(print);
            //Return:
            //       2
            //       1
            //       4

            Console.WriteLine("Collection as an integer array:");
            Console.WriteLine(list.ToArray());
            Console.WriteLine(String.Join(Environment.NewLine, list.ToArray()));
            //Return:
            //       System.Int32[]
            //       2
            //       1
            //       4
        }
    }
}