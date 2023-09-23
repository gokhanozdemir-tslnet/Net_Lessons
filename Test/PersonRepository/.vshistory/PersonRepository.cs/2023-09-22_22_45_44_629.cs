using AppService.DbContexts;
using AppService.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryContracts;

namespace PersonRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _db;

        public PersonRepository(AppDbContext db)
        {
            _db = db;
        }


        public async Task<Person> AddPerson(Person person)
        {
           await _db.Persons.AddAsync(person);
           await _db.SaveChangesAsync();  

            return person;
        }

        public async Task<Person> UpdatePerson(Person person)
        {
            Person? updatePerson = await _db.Persons.FirstOrDefaultAsync(x=> x.Id == person.Id);
            if (updatePerson == null)
                return person;
            updatePerson.Name = person.Name;
            updatePerson.Email = person.Email;

            int countUpdated = await _db.SaveChangesAsync();

            return updatePerson;

        }

        public async Task<List<Person>> GetAllPersons()
        {
            return await _db.Persons.ToListAsync();
        }

        public async Task<Person?> GetPersonByPersonId(int id)
        {
            return await _db.Persons.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task<Person?> GetPersonByPersonName(string name)
        {
            return await _db.Persons.FirstOrDefaultAsync(x => x.Name == name);
        }

        
    }
}