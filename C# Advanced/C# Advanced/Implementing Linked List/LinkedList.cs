using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; } = 0;

        public void AddFirst(Node node)
        {
            if (Head == null)
            {
                Tail = node;
                Head = node;
                return;
            }
            Head.Previous = node;
            node.Next = Head;
            Head = node;

            Count++;
        }

        public void AddFirst(int value)
        {
            AddFirst(new Node(value));
        }

        public void AddLast(Node node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;

            Count++;
        }

        public void AddLast(int value)
        {
            AddLast(new Node(value));
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            int firstHead = Head.Value;
            Head = Head.Next;
            Head.Previous = null;

            return firstHead;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            int lastTail = Tail.Value;
            Tail = Tail.Previous;

            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }

            Count--;
            return lastTail;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;

            var currentNode = Head;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }

            return array;
        }
    }
}
