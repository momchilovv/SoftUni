using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public StackOfStrings()
        {

        }

        public bool IsEmpty()
        {
            if (Count < 1)
            {
                return true;
            }

            return false;
        }

        public Stack<string> AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }

            return this;
        }
    }
}