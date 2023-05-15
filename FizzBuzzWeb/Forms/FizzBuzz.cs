using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Year")]
        [Required(ErrorMessage = "This field is required"), Range(1899, 2050, ErrorMessage = "Expected value {0} between {1} and {2}")]
        public int Number { get; set; }

        [Display(Name = "Name")]
        [MaxLength(100, ErrorMessage = "Max size of Name is 100 characters")]
        public string username { get; set; }

        [Display(Name = "Result")]
        public string result { get; set; }
    }
}

