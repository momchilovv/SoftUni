using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> list;

        public Lake(List<int> stones)
        {
            list = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i += 2)
            {
                yield return list[i];
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if(i % 2 == 1) yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}