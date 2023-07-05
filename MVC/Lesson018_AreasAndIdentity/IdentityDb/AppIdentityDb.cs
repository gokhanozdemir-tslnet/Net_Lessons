using Lesson018_AreasAndIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lesson018_AreasAndIdentity.IdentityDb
{
    public class AppIdentityDbContext: IdentityDbContext<AppUser,AppRole,Guid>
    {
        public AppIdentityDbContext(DbContextOptions option):base(option)
        {

        }
    }
}
