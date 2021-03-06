using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webgentle.BookStore.Models
{

    public class BookModel
    {
        [DataType(DataType.DateTime)]
        [Display(Name = "Choose data and time")]
        public string MyField { get; set; }
        public int Id { get; set; }
        //[StringLength(100,MinimumLength =5)]
        //[Required(ErrorMessage="Please enter the title of your book")]

        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter the author name")]
        //[MyCustomValidation(Text = "Azure")]
        public string Title { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Please choose the language of your book")]
        public int LanguageId { get; set; }
        public string Language { get; set; }
        //[Required(ErrorMessage = "Please choose the language of your book")]
        //public LanguageEnum languageEnum { get; set; }
        [Required(ErrorMessage = "Please enter the total pages")]
        [Display(Name = "Total pages of book")]
        public int TotalPage { get; set; }
        [Display(Name = "Choose the cover photo of your book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the cover image of your book")]
        [Required]
        public IFormFileCollection GalleryFile { get; set; }
        public List<GalleryModel> Gallery { get; set; }
        [Display(Name = "Upload Your book in pdf format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }
    }
}
