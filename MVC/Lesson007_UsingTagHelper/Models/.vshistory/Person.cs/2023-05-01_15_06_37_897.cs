using System.ComponentModel.DataAnnotations;

namespace Lesson007_UsingTagHelper.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }


    }
}
