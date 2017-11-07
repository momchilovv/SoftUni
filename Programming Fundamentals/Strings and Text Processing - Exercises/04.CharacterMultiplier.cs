using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string first = input[0];
            string second = input[1];
            var firstList = new List<int>();
            var secondList = new List<int>();

            foreach (var ch in first)
            {
                firstList.Add((int)ch);
            }
            foreach (var ch in second)
            {
                secondList.Add((int)ch);
            }
            var result = firstList.Sum() * secondList.Sum();
            Console.WriteLine(result);
        }
    }
}
