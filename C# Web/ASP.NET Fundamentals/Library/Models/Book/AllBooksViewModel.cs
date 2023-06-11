﻿#nullable disable
namespace Library.Models.Book
{
    public class AllBooksViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public decimal Rating { get; set; }

        public string Category { get; set; }
    }
}