using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString(List<string> list)
        {
            Random random = new Random();

            string randomString = list[random.Next(0, list.Count + 1)];

            return randomString;
        }
    }
}