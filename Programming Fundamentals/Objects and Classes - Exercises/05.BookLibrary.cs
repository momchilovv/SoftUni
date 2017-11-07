using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();
            input = Books.Read(input[0], 
                input[1], 
                input[2], 
                DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                int.Parse(input[4]),
                double.Parse(input[5])
                ;
            for (int i = 0; i < n; i++)
            {

            }
        }
    }
    //class Library
    //{
        //public string Name { get; set; }
        //public List<Books> Books { get; set; }
    //}
    public class Books
    {
        public BooksRead(string title, string author, string publisher, DateTime releaseDate, int isbn, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }

        public static List<Books> Read(string title, string author, string publisher, DateTime releaseDate, int isbn, double price)
        {
            var input = Console.ReadLine().Split();
            List<Books> list = new List<Books>();
            foreach (var item in input)
            {
                list.Add(new Books(title, author, publisher, releaseDate, isbn, price));
            }
            return list;
        }
    }
}
