using System;
using System.Globalization;

namespace _13._1000DaysOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            const string format = "dd-MM-yyyy";
            
            DateTime answer = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            Console.WriteLine(answer.AddDays(999).ToString(format));
        }
    }
}