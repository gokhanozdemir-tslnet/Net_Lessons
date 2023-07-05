using Microsoft.AspNetCore.Identity;

namespace Lesson018_AreasAndIdentity.Entities
{
    public class AppRole:IdentityRole<Guid>
    {
        public string Name { get; set; }
    }
}
