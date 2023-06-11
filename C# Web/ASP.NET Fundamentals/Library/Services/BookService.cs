using Library.Contracts;
using Library.Data;
using Library.Data.Models;
using Library.Models.Book;
using Library.Models.Category;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext dbContext;

        public BookService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddBookAsync(AddBookViewModel model)
        {
            var book = new Book()
            {
                Author = model.Author,
                Title = model.Title,
                Description = model.Description,
                ImageUrl = model.Url,
                Rating = model.Rating,
                CategoryId = model.CategoryId
            };

            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
        }

        public async Task AddToCollectionAsync(string userId, BookViewModel model)
        {
            if (!await dbContext.IdentityUserBooks.AnyAsync(
                b => b.CollectorId == userId && b.BookId == model.Id))
            {
                await dbContext.IdentityUserBooks.AddAsync(new IdentityUserBook
                {
                    CollectorId = userId,
                    BookId = model.Id
                });

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<AddBookViewModel> GetAddNewBookModelAsync()
        {
            var categories = await dbContext.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            var model = new AddBookViewModel
            {
                Categories = categories
            };

            return model;
        }

        public async Task<ICollection<AllBooksViewModel>> GetAllBooksAsync()
        {
            return await dbContext.Books
                .Select(book => new AllBooksViewModel
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Rating = book.Rating,
                    Category = book.Category.Name,
                    ImageUrl = book.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<BookViewModel> GetBookByIdAsync(int id)
        {
            return await dbContext.Books
                .Where(book => book.Id == id)
                .Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Rating = b.Rating,
                    Description = b.Description,
                    CategoryId = b.CategoryId,
                    ImageUrl = b.ImageUrl
                })
                .FirstAsync();
        }

        public async Task<ICollection<MineBooksViewModel>> GetMineBooksAsync(string userId)
        {
            return await dbContext.IdentityUserBooks
                .Where(ub => ub.CollectorId == userId)
                .Select(book => new MineBooksViewModel
                {
                    Id = book.Book.Id,
                    Title = book.Book.Title,
                    Author = book.Book.Author,
                    Category = book.Book.Category.Name,
                    ImageUrl = book.Book.ImageUrl,
                    Description = book.Book.Description
                })
                .ToListAsync();
        }

        public async Task RemoveFromCollectionAsync(string userId, BookViewModel model)
        {
            var userBook = await dbContext.IdentityUserBooks
                .FirstOrDefaultAsync(b => b.CollectorId == userId && b.BookId == model.Id);

            if (userBook != null)
            {
                dbContext.IdentityUserBooks.Remove(userBook);

                await dbContext.SaveChangesAsync();
            }
        }
    }
}