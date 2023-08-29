
using AppService.DbContexts;
using AppService.Entities;

namespace AppService.Repositories
{
    public class PersonRepository
    {
        private readonly AppDbContext _dbContext;

        public PersonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Person> GetAllPerson()
        {
            return _dbContext.Persons.ToList();
        }


        public Person AddPerson(Person person)
        {
            _dbContext.Persons.Add(person);
            _dbContext.SaveChangesAsync();
            return person;
        }

    }
}
