using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Validations
{
    public class FirstLetterUpperCaseAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value ==null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstLetter = value.ToString()[0].ToString();
            if (firstLetter!=firstLetter.ToUpper())
            {
                return new ValidationResult("First Letter Should be uppercase!");
            }
            return ValidationResult.Success;
        }
    }
}
