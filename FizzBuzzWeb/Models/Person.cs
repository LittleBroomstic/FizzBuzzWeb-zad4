using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FizzBuzzWeb.Models
{
    public class Person
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "This field is required"), Range(1899, 2050, ErrorMessage = "Expected value {0} between {1} and {2}")]
        public int Number { get; set; }

        [Display(Name = "Name")]
        [MaxLength(100, ErrorMessage = "Max size of Name is 100 characters")]
        [AllowNull] public string username { get; set; } = "user";

        [Display(Name = "Result")]
        public string result { get; set; }

        [Display(Name = "Data")]
        public DateTime date { get; set; }

        [AllowNull]
        [Display(Name = "Login")]
         public string login { get; set; }
        
        [AllowNull]
        [Display(Name = "UserID")]
         public string userID { get; set; } = "No ID";
    }
}
