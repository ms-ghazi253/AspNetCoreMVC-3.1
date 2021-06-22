using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    [Route("[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILanguageRepository _languageRepository = null;
        public BookController(IBookRepository bookRepository,
            ILanguageRepository languageRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _languageRepository = languageRepository;
            _bookRepository = bookRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        [Route("~/all-books")]
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        //public ViewResult GetBook(int id , string nameofbook)
        //{
        //    dynamic data = new ExpandoObject();

        //   data.book = _bookRepository.GetBookById(id);
        //    data.Name = "mohammad";
        //    return View(data);
        //}
        [Route("~/book-Details/{id}", Name = "bookDetailsRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);
            return View(data);
        } 
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        public async Task<ViewResult> AddnewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel()
            {
                //Language = "2"
            };
            ViewBag.Languages = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            //var Group1 = new SelectListGroup() { Name = "Group 1" };
            //var Group2 = new SelectListGroup() { Name = "Group 2" };
            //var Group3 = new SelectListGroup() { Name = "Group 3" };
            //ViewBag.language = new List<SelectListItem>()
            //{
            //    new SelectListItem(){Text = "Hindi" , Value="1" , Group=Group1 },
            //    new SelectListItem(){Text = "Persin" , Value="2", Group=Group1 },
            //    new SelectListItem(){Text = "English" , Value="3", Group=Group1 },
            //    new SelectListItem(){Text = "Ruassan" , Value="4", Group=Group2 },
            //    new SelectListItem(){Text = "Trukish" , Value="5", Group=Group2 },
            //     new SelectListItem(){Text = "Urdu" , Value="6" , Group=Group2},
            //      new SelectListItem(){Text = "Chinese" , Value="7" , Group=Group3},
            //       new SelectListItem(){Text = "Tamil" , Value="8" , Group=Group3},
            //        new SelectListItem(){Text = "Spanish" , Value="9" , Group=Group3},
            //};
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddnewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                if (bookModel.CoverPhoto != null)
                {
                    string folder = "books/cover/";
                    bookModel.CoverImageUrl=await UploadImage(folder, bookModel.CoverPhoto);
                }
                if (bookModel.GalleryFile != null)
                {
                    string folder = "books/gallery/";
                    bookModel.Gallery = new List<GalleryModel>();

                    foreach(var file in bookModel.GalleryFile)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name=file.FileName,
                            URL = await UploadImage(folder, file)

                    };
                        bookModel.Gallery.Add(gallery);   
                    }
                    
                }
                if (bookModel.BookPdf != null)
                {
                    string folder = "books/PDF/";
                    bookModel.BookPdfUrl = await UploadImage(folder, bookModel.BookPdf);
                }
                int id = await _bookRepository.AddnewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddnewBook), new { isSuccess = true, bookId = id });
                }
            }
            ViewBag.Languages = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            //ViewBag.language = new SelectList(GetLanguage(), "Id", "Text");
            ModelState.AddModelError("", "this is my custom error message");
            return View();
        }

        private async Task<string> UploadImage(string folderPath,IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            
            string ServerFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(ServerFolder, FileMode.Create));
            return "/" + folderPath;
        }
        //private List<LanguageModel> GetLanguage()
        //{
        //    return new List<LanguageModel>()
        //    {
        //        new LanguageModel(){Id=1,Text="Hindi" },
        //        new LanguageModel(){Id=2,Text="English" },
        //        new LanguageModel(){Id=3,Text="Dutch"}
        //    };
        //}
    }
}
