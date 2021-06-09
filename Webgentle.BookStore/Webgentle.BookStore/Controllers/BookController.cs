using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ViewResult>GetAllBooks()
        {
            var data= await _bookRepository.GetAllBooks() ;
            return View(data);
        }
        //public ViewResult GetBook(int id , string nameofbook)
        //{
        //    dynamic data = new ExpandoObject();

        //   data.book = _bookRepository.GetBookById(id);
        //    data.Name = "mohammad";
        //    return View(data);
        //}
        [Route("book-Details/{id}" , Name="bookDetailsRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        public ViewResult AddnewBook(bool isSuccess=false , int bookId=0)
        {
            var model = new BookModel()
            {
                //Language = "English"
            };
            ViewBag.language = new SelectList(GetLanguage(),"Id","Text");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model); 
        }
        [HttpPost]
        public async Task<IActionResult> AddnewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddnewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddnewBook), new { isSuccess = true, bookId = id });
                }
            }
            ViewBag.language = new SelectList(GetLanguage(), "Id", "Text");
            ModelState.AddModelError("", "this is my custom error message");
            return View();
        }
        private List<LanguageModel> GetLanguage()
        {
            return new List<LanguageModel>()
            {
                new LanguageModel(){Id=1,Text="Hindi" },
                new LanguageModel(){Id=2,Text="English" },
                new LanguageModel(){Id=3,Text="Dutch"}
            };
        }
    }
}
