using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Data;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        //private List<BookModel> DataSource()
        //{
        //    return new List<BookModel>()
        //    {
        //        new BookModel(){Id=1 , Title="MVC",Author="NItish" , Discription="this is about MVCModel", Category="Programming" , Language="English",TotalPage=1241},
        //        new BookModel(){Id=2 , Title="Dot Net Core",Author="karenly" , Discription="this is a dotnet Core in iran ",Category="sport" , Language="Persian",TotalPage=152},
        //        new BookModel(){Id=3 , Title="MVC",Author="monika" , Discription="what do you think about this?",Category="math" , Language="spanish",TotalPage=1122},
        //        new BookModel(){Id=4 , Title="php",Author="webgentle" , Discription="this is website for toturiaal ",Category="fizisks" , Language="Rusion",TotalPage=1764},
        //        new BookModel(){Id=5 , Title="F#",Author="webgentle" , Discription="this is about F# toturial " ,Category="sosial" , Language="Arabic",TotalPage=1844}, 
        //    };
        //}
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddnewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Discription,
                Title = model.Title,
                LanguageId = model.LanguageId,
                TotalPages = model.TotalPage,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                BookPdfUrl = model.BookPdfUrl
            };
            newBook.bookGallery = new List<BookGallery>();
            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }
    
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allbooks = await _context.Books.Include(b => b.Language).ToListAsync();
            if (allbooks?.Any() == true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Category = book.Category,
                        Discription = book.Description,
                        Id = book.Id,
                        LanguageId = book.LanguageId,
                        Language = book.Language.Name,
                        Title = book.Title,
                        TotalPage = book.TotalPages,
                        CoverImageUrl = book.CoverImageUrl
                    });
                }
            }
            return books;
        }
        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {
            return await _context.Books.Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Discription = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPage = book.TotalPages,
                CoverImageUrl = book.CoverImageUrl
            }).Take(count).ToListAsync();

        }
        public async Task<BookModel> GetBookById(int id)
        {
            return await _context.Books.Where(x => x.Id == id).Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Discription = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPage = book.TotalPages,
                CoverImageUrl = book.CoverImageUrl,
                Gallery = book.bookGallery.Select(g => new GalleryModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    URL = g.URL
                }).ToList(),
                BookPdfUrl = book.BookPdfUrl
            }).FirstOrDefaultAsync();
        }

        public async  Task<BookModel> GetId()
        {
            
            var books =  new BookModel();
            
            var remove =  await _context.Books.FirstOrDefaultAsync(p=>p.Id==books.Id);
            _context.Remove(remove);
            _context.SaveChanges();
            return books;
        }
        public string GetAppName()
        {
            return "Book Store application";
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }

    }
}
