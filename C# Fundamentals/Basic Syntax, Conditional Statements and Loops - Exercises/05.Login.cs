using System;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        char[] reverse = username.ToCharArray();
        Array.Reverse(reverse);

        for (int i = 1; i <= 4; i++)
        {
            string input = Console.ReadLine();
            if (input == new string(reverse))
            {
                Console.WriteLine($"User {username} logged in.");
                Environment.Exit(0);
            }
            if (i == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}