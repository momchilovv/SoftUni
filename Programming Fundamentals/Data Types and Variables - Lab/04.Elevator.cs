using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            if (numberOfPeople % capacity == 0)
            {
                courses = numberOfPeople / capacity;
            }
            else
            {
                courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            }
            Console.WriteLine(courses);
        }
    }
}