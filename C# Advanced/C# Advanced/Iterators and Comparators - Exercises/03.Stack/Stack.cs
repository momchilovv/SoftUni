using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;

        private T[] items;

        public int Count { get; private set; }

        public Stack()
        {
            items = new T[InitialCapacity];
        }

        public void Push(T item)
        {
            if (items.Length == Count)
            {
                T[] copy = new T[items.Length * 2];

                for (int i = 0; i < Count; i++)
                {
                    copy[i] = items[i];
                }

                items = copy;
            }

            items[Count] = item;

            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                Console.WriteLine("No elements");
                Environment.Exit(0);
            }

            Count--;

            return items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}