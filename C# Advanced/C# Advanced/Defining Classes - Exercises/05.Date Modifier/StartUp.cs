using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int[] firstDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondDate = Console.ReadLine().Split().Select(int.Parse).ToArray();

            DateModifier dateModifier = new DateModifier();

            Console.WriteLine(Math.Abs(dateModifier.GetDifference(firstDate, secondDate).TotalDays));
        }
    }
}