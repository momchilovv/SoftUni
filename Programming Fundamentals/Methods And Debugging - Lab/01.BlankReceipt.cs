using System;

namespace _01.BlankReceipt
{
    class Program
    { 
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Charged by____________________");
        }
        static void PrintBottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            PrintHeader();
            PrintMiddle();
            PrintBottom();
        }
    }
}