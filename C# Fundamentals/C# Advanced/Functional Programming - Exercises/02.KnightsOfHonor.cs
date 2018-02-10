using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> names = () => Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<List<string>> knightNames = name => Console.WriteLine("Sir " + string.Join("\r\nSir ", name));

            var input = names();
            List<string> knights = new List<string>();
            foreach (var name in input)
            {
                knights.Add(name);
            }
            knightNames(knights);
        }
    }
}