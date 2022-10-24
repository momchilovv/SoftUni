using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<Person>();

            var set = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                Person person = new Person()
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };


                hashSet.Add(person);
                set.Add(person);
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(set.Count);
        }
    }
}