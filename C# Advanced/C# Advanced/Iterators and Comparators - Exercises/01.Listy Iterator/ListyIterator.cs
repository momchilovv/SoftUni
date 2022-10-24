using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}