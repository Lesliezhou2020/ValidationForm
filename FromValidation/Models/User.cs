using System;
using System.ComponentModel.DataAnnotations;
namespace FromValidation.Models
{
    public class User
    {
        [Display(Name="FirstName: ", Prompt="Enter your First name here")]
        [Required(ErrorMessage="First name is required.")]
        [MinLength(4, ErrorMessage="First name must be at least 4 characters.")]
        public string FirstName { get; set; }

        [Display(Name="LastName: ", Prompt="Enter your Last name here")]
        [Required(ErrorMessage="Last name is required.")]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters.")]
        public string LastName { get; set; }

        [Display(Name="Age: ")]
        [Required(ErrorMessage="Age is required.")]
        public int Age { get; set; }
        
        [Display(Name="Email: ")]
        [Required(ErrorMessage="Email is required.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage="Invalid email address.")]
        public string Email { get; set; }
 
        [Display(Name="Password:")]
        [Required(ErrorMessage="Password is required.")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        public string Password { get; set; }
    }
}
