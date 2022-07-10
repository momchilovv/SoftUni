using System;

class Program
{
    static void Main(string[] args)
    {
        string movie = Console.ReadLine();

        double ticketsSold = 0, studentTickets = 0, standardTickets = 0, kidTickets = 0;

        while (movie != "Finish")
        {
            double seats = int.Parse(Console.ReadLine());
            double studentsCount = 0, standardsCount = 0, kidsCount = 0, totalTicketsCount = 0;

            for (int i = 0; i < seats; i++)
            {
                string type = Console.ReadLine();
                if (type == "End")
                {
                    break;
                }
                if (type == "student")
                {
                    studentsCount++;
                    studentTickets++;
                }
                else if (type == "standard")
                {
                    standardsCount++;
                    standardTickets++;
                }
                else if (type == "kid")
                {
                    kidsCount++;
                    kidTickets++;
                }
                totalTicketsCount++;
                ticketsSold++;
            }

            Console.WriteLine($"{movie} - {100 * totalTicketsCount / seats:f2}% full.");

            movie = Console.ReadLine();
        }

        Console.WriteLine($"Total tickets: {ticketsSold}");
        Console.WriteLine($"{100 * studentTickets / ticketsSold:f2}% student tickets.");
        Console.WriteLine($"{100 * standardTickets / ticketsSold:f2}% standard tickets.");
        Console.WriteLine($"{100 * kidTickets / ticketsSold:f2}% kids tickets.");
    }
}