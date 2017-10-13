using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var list = new List<int>();

            foreach (var num in list)
            {
                list.Add(num);
            }

            var commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            list.Take(commands[0]);
            list.Remove(commands[1]);

            //int result = list.Find(x => x);
            foreach (var num in list)
            {
                
            }
            //if (result == commands[2])
            {
                Console.WriteLine("yes");
            }
            //Console.WriteLine(result);
                

        }
    }
}
