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
                new BookModel(){Id=1 , Title="MVC",Author="NItish" , Discription="this is about MVCModel"},
                new BookModel(){Id=2 , Title="Dot Net Core",Author="karenly" , Discription="this is a dotnet Core in iran "},
                new BookModel(){Id=3 , Title="MVC",Author="monika" , Discription="what do you think about this?"},
                new BookModel(){Id=4 , Title="php",Author="webgentle" , Discription="this is website for toturiaal "},
                new BookModel(){Id=5 , Title="F#",Author="webgentle" , Discription="this is about F# toturial "}, 
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
