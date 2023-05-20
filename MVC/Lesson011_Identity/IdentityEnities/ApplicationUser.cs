using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lesson011_Identity.IdentityEnities
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        [Required(ErrorMessage ="Name cannot be blank!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname cannot be blank!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email cannot be blank!")]
        [EmailAddress(ErrorMessage ="Email should be in proper email adress format!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be blank!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password cannot be blank!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Phone cannot be blank!")]
        public string Phone { get; set; }
        
    }
}
