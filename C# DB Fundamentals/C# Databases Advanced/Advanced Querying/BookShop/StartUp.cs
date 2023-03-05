namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            Console.WriteLine(RemoveBooks(db));
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            context.Books.RemoveRange(books);

            context.SaveChanges();

            return books.Length;
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate!.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    Books = c.CategoryBooks.Select(b => new
                    {
                        Title = b.Book.Title,
                        ReleaseDate = b.Book.ReleaseDate!.Value
                    })
                    .OrderByDescending(b => b.ReleaseDate)
                    .Take(3)
                })
                .OrderBy(c => c.Name);

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.Name}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseDate.Year})");
                }
            }          

            return sb.ToString().Trim();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    TotalEarnings = c.CategoryBooks
                                     .Select(b => b.Book.Copies * b.Book.Price)
                                     .Sum()
                })
                .OrderByDescending(c => c.TotalEarnings)
                .ThenBy(c => c.Name);

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Name} ${category.TotalEarnings:f2}");
            }

            return sb.ToString().Trim();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck);

            return books.Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            var authors = context.Authors
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Where(b => b.AuthorId == a.AuthorId)
                                    .Select(b => b.Copies)
                                    .Sum()
                })
                .OrderByDescending(a => a.Copies);

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FullName} - {author.Copies}");
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    BookId = b.BookId,
                    Title = b.Title,
                    AuthorFirstName = b.Author.FirstName,
                    AuthorLastName = b.Author.LastName
                })
                .OrderBy(b => b.BookId);

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorFirstName} {book.AuthorLastName})");
            }

            return sb.ToString().Trim();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title);

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().Trim();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input));

            foreach (var author in authors.OrderBy(a => a.FirstName).ThenBy(a => a.LastName))
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }


            return sb.ToString().Trim();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Select(b => new
                {
                    Title = b.Title,
                    EditionType = b.EditionType,
                    Price = b.Price,
                    ReleaseDate = b.ReleaseDate
                })
                .Where(b => b.ReleaseDate!.Value.Date < DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture))
                .OrderByDescending(b => b.ReleaseDate);


            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var bookList = new List<string>();

            var categories = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var books = context.BooksCategories
                .Select(b => new
                {
                    BookTitle = b.Book.Title,
                    BookCategory = b.Category.Name
                });

            foreach (var category in categories)
            {
                foreach (var book in books.Where(b => b.BookCategory.ToLower() == category.ToLower()))
                {
                    bookList.Add(book.BookTitle);
                }
            }

            sb.AppendLine(string.Join(Environment.NewLine, bookList.OrderBy(b => b)));

            return sb.ToString().Trim();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.ReleaseDate!.Value.Year != year)
                .OrderBy(b => b.BookId);

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(p => p.Price);

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.Copies < 5000)
                .OrderBy(b => b.BookId);

            foreach (var book in books.Where(b => b.EditionType.Equals(EditionType.Gold)))
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var books = context.Books.ToList();

            foreach (var book in books.Where(b => b.AgeRestriction.ToString().ToLower().Equals(command.ToLower())).OrderBy(b => b.Title))
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().Trim();
        }
    }
}