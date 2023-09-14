
using Microsoft.EntityFrameworkCore;
using PersonDBContextApp.Entities;

namespace PersonDBContextApp.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
