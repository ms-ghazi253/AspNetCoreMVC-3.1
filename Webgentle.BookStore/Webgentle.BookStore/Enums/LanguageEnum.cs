using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Enums
{
    public enum LanguageEnum
    {
        [Display(Name ="Hindi language")]
        Hindi,
        [Display(Name = "English language")]
        English,
        [Display(Name = "German language")]
        German,
        [Display(Name = "Chinese language")]
        Chinese,
        [Display(Name = "Urdu language")]
        Urdu
    }
}
