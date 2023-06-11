using Library.Models.Book;

namespace Library.Contracts
{
    public interface IBookService
    {
        Task<ICollection<AllBooksViewModel>> GetAllBooksAsync();

        Task AddToCollectionAsync(string userId, BookViewModel model);

        Task RemoveFromCollectionAsync(string userId, BookViewModel model);

        Task<ICollection<MineBooksViewModel>> GetMineBooksAsync(string userId);

        Task<BookViewModel> GetBookByIdAsync(int id);

        Task<AddBookViewModel> GetAddNewBookModelAsync();

        Task AddBookAsync(AddBookViewModel model);
    }
}