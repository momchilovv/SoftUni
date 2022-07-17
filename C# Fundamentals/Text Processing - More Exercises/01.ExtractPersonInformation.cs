using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string input = Console.ReadLine();

            string name = input.Substring(input.IndexOf('@') + 1, input.IndexOf('|') - input.IndexOf('@') - 1);
            int age = int.Parse(input.Substring(input.IndexOf('#') + 1, input.IndexOf('*') - input.IndexOf('#') - 1));

            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}