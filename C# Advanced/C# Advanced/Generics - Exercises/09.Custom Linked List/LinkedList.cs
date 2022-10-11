using System;

namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; } = 0;

        public void AddFirst(Node<T> node)
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

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        public void AddLast(Node<T> node)
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

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T firstHead = Head.Value;
            Head = Head.Next;
            Head.Previous = null;

            return firstHead;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T lastTail = Tail.Value;
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

        public void ForEach(Action<T> action)
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
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