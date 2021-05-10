using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult  GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks() ;
            return View(data);
        }
        public ViewResult GetBook(int id , string nameofbook)
        {
            dynamic data = new ExpandoObject();

           data.book = _bookRepository.GetBookById(id);
            data.Name = "mohammad";
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        public ViewResult AddnewBook()
        {
            return View(); 
        }
        [HttpPost]
        public ViewResult AddnewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
