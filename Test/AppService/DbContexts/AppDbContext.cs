

using AppService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppService.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public virtual DbSet<Person> Persons { get; set; }
    }
}
