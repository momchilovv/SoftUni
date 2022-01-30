using System;

class Program
{
    static void Main(string[] args)
    {
        string searchedBook = Console.ReadLine();
        string foundedBook = null;
        int checkedBooks = 0;

        while (foundedBook != searchedBook || foundedBook != "No More Books")
        {
            foundedBook = Console.ReadLine();            

            if (foundedBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
                System.Environment.Exit(0);
            }
            else if (foundedBook == searchedBook)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
                System.Environment.Exit(0);
            }
            if (foundedBook != searchedBook)
                checkedBooks++;
        }
    }
}