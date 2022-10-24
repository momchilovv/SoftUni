using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        private List<T> items;

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }

        public bool Move()
        {
            if (items.Count - 1 > index)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return index < items.Count - 1;
        }

        public string Print()
        {
            if (items.Count == 0)
            {
                return "Invalid Operation!";
            }
            return items[index].ToString();
        }

        public string PrintAll()
        {
            var sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.Append(item + " ");
            }

            return sb.ToString().TrimEnd();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}