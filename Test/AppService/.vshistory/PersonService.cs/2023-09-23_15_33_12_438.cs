

using AppService.DbContexts;
using AppService.Dtos;
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

        public async Task<AddPersonResponse> AddPersonAsync(AddPersonRequest personrequest)
        {
            var person = personrequest.ToPerson();
            if (person==null)
            {
                throw new ArgumentNullException(nameof(person));    
            }
            //Thread.Sleep(30000);
            await _db.Persons.AddAsync(person.ToPerson());
            await _db.SaveChangesAsync();
            return person.;
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
