using System;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] elements;
        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return elements[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                elements[index] = value;
            }
        }

        public CustomList()
        {
            elements = new int[InitialCapacity];
        }

        public void Add(int element)
        {
            if (Count == elements.Length)
            {
                Resize();
            }

            elements[Count] = element;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int currentElement = elements[index];
            elements[index] = default(int);

            for (int i = index; i < Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            if (Count <= elements.Length / 4)
            {
                int[] copy = new int[elements.Length / 2];

                for (int i = 0; i < Count; i++)
                {
                    copy[i] = elements[i];
                }
                elements = copy;
            }
            Count--;

            return currentElement;
        }

        public void Insert(int index, int element)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count == elements.Length)
            {
                Resize();
            }

            for (int i = Count; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }

            elements[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            foreach (var el in elements.Where(e => e == element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= Count || secondIndex >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int value = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = value;
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