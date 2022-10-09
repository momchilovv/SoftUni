using System;

namespace DataStructures
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;

        private int[] elements;

        public CustomQueue()
        {
            elements = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (elements.Length == Count)
            {
                Resize();
            }
            elements[Count] = element;

            Count++;
        }

        public int Peek()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty.");
            }

            return elements[0];
        }

        public int Dequeue()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty.");
            }
            Count--;

            int removedElement = elements[0]; 

            for (int i = 1; i < elements.Length; i++)
            {
                elements[i - 1] = elements[i];
            }

            elements[elements.Length - 1] = 0;

            return removedElement;
        }

        public void Clear()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
        }

        private void Resize()
        {
            int[] copy = new int[elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                copy[i] = elements[i];
            }

            elements = copy;
        }
    }
}