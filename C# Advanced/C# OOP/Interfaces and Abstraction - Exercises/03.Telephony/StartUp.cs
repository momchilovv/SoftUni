using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            string[] websites = Console.ReadLine().Split();

            IBrowseable smartphone = new Smartphone(numbers, websites);
            
            smartphone.Call();
            smartphone.Browse();
        }
    }
}