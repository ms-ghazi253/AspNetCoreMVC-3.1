using System.Collections.Generic;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddnewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);

        string GetAppName();
    }
}