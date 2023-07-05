using Microsoft.AspNetCore.Identity;

namespace Lesson018_AreasAndIdentity.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
    }
}
