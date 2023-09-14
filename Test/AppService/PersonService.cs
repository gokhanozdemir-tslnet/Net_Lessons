

using AppService.DbContexts;
using AppService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppService
{
    public class PersonService : IPersonService
    {
        private readonly AppDbContext _db;
        public PersonService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Person> AddPersonAsync(Person person)
        {
            if (person==null)
            {
                throw new ArgumentNullException(nameof(person));    
            }
            //Thread.Sleep(30000);
            await _db.Persons.AddAsync(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>> GetAllPerson()
        {
            return await _db.Persons.ToListAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await  _db.Persons.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
