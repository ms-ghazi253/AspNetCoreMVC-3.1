using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1 , Title="MVC",Author="NItish"},
                new BookModel(){Id=2 , Title="Dot Net Core",Author="karenly"},
                new BookModel(){Id=3 , Title="MVC",Author="monika"},
                new BookModel(){Id=4 , Title="php",Author="webgentle"},
                new BookModel(){Id=5 , Title="F#",Author="webgentle"},
            };
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource(); 
        }
        public BookModel GetBookById (int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        } 
        public List<BookModel> SearchBook(string title , string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author == authorName).ToList();
        }
      
    }
}
