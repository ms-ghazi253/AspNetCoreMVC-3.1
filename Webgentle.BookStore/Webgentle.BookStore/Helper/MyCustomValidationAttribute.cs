using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Helper
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        public string Text { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string booName = value.ToString();
                if(booName.Contains(Text))
                    {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("BookName does not contain the desired value");
        }
    }
}
