using System;
using System.Text;

namespace DataStructures
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] elements;

        public CustomStack()
        {
            elements = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (elements.Length == Count)
            {
                Resize();
            }
            elements[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty.");
            }
            Count--;

            return elements[Count];
        }
        
        public int Peek()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty.");
            }

            return elements[Count - 1];
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

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                stringBuilder.AppendLine(elements[i].ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}