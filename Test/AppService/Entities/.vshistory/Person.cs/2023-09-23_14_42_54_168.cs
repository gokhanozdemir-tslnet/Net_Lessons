

using System.ComponentModel.DataAnnotations.Schema;

namespace AppService.Entities
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get;set; }
        public string Address { get; set; }
        public string Email { get; set; }   
    }


    pub
}
