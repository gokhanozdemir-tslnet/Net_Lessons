using Lesson002_UsingEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson002_UsingEFCore.Data
{
    public class WAPILesson002DbContext:DbContext
    {
        public WAPILesson002DbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<City>  Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<City>().HasData(


            //    new City {  CityName = "CityName1" },
            //    new City {  CityName = "CityName2" },
            //    new City {  CityName = "CityName3" },
            //    new City {  CityName = "CityName4" }

            //    );
        }
    }
}
