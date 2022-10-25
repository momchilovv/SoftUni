using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            
            List<string> names = new List<string>()
            {
                "Pesho", "Gosho", "Ivan", "Stamat"
            };

            Console.WriteLine(randomList.RandomString(names));
        }
    }
}