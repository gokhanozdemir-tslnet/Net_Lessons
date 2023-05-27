using System.ComponentModel.DataAnnotations;

namespace Lesson011_Identity.Models
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email cannot be blank!")]
        [EmailAddress(ErrorMessage = "Email should be in proper email adress format!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be blank!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
