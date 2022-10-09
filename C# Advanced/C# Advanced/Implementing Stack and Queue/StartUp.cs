using System;

namespace DataStructures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            #region List Structure Testing
            CustomList customList = new CustomList();

            //Adding few elements to the list
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            Console.WriteLine("Printing the original list:");
            Console.WriteLine(customList.ToString());
            Console.WriteLine();

            //Removing the second element(2) - index[1]
            //List: 1 3 4 5
            customList.RemoveAt(1);

            //Let's bring back the 2 but this time at the second position - index[2]
            //List: 1 3 2 4 5
            customList.Insert(2, 2);

            //Testing the contains method
            //Check if the number (8) - False
            Console.WriteLine("Contains 8? " + customList.Contains(8) + Environment.NewLine);
            //Check again for number (2) - True
            Console.WriteLine("Contains 2? " + customList.Contains(2) + Environment.NewLine);

            //Now let's try swapping the last and first element of the list
            //List: 5 3 2 4 1
            customList.Swap(4, 0);

            Console.WriteLine("Printing the final state of the list:");
            Console.WriteLine(customList.ToString());
            #endregion

            #region Stack Structure Testing
            CustomStack customStack = new CustomStack();

            Console.WriteLine();
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            customStack.Push(5);

            Console.WriteLine("Printing original stack without removing the elements:");
            Console.WriteLine(customStack.ToString() + Environment.NewLine);

            //Current count of the stack
            Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);

            //Peek() - should return 5
            Console.WriteLine("Peek(): " + customStack.Peek() + Environment.NewLine);

            //Pop() - should return 5 and remove it from the collection - new count = 4
            Console.WriteLine("Pop(): " + customStack.Pop() + Environment.NewLine);

            //Current count and elements of the stack
            Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);
            Console.WriteLine("Current elements in the stack:");
            Console.WriteLine(customStack.ToString() + Environment.NewLine);

            customStack.Push(5);
            customStack.Push(6);

            //Current count and elements of the stack
            Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);
            Console.WriteLine("Current elements in the stack:");
            Console.WriteLine(customStack.ToString() + Environment.NewLine);
            #endregion

            #region Queue Structure Testing
            CustomQueue customQueue = new CustomQueue();

            //Adding elements to the Queue
            customQueue.Enqueue(1);
            customQueue.Enqueue(2);
            customQueue.Enqueue(3);

            Console.WriteLine("Printing original queue without removing the elements:");
            customQueue.ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            //Removing the first element from the Queue with Dequeue method (1)
            Console.WriteLine("Dequeue(): " + customQueue.Dequeue() + Environment.NewLine);

            //Printing the Queue Count which is now 2
            Console.WriteLine("Count: " + customQueue.Count + Environment.NewLine);

            //Adding two new elements to the Queue -> 4, 5
            customQueue.Enqueue(4);
            customQueue.Enqueue(5);

            //The collection is now 2, 3, 4, 5 with Count: 4
            customQueue.ForEach(n => Console.WriteLine(n));

            //Clear the Queue with .Clear() method -> removes all elements in the Queue
            customQueue.Clear();

            //Now we don't have anything in the Queue so the Count is restarted to 0
            Console.WriteLine(Environment.NewLine + "Count: " + customQueue.Count);
            #endregion
        }
    }
}