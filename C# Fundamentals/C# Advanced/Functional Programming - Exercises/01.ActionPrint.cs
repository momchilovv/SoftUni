using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> names = () => Console.ReadLine().Split().ToArray();

            Action<List<string>> printedNames = name => Console.WriteLine(string.Join("\r\n", name));

            var input = names();
            List<string> list = new List<string>();
            foreach (var name in input)
            {
                list.Add(name);
            }
            printedNames(list);
        }
    }
}