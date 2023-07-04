using System.ComponentModel.DataAnnotations;

namespace Lesson016_Filters.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name boş geçilemez")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Addres { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
