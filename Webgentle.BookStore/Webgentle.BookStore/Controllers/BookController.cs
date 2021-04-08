using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "Get All Books books";
        }
        public string GetBook(int id)
        {
            return $"book with id ={id}";
        }
        public string SearchBooks(string bookName, string authorName)
        {
            return $"Boom with name = {bookName} & Author = {authorName}";
        }
    }
}
