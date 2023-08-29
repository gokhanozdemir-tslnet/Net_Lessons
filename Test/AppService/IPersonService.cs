

using AppService.DbContexts;
using AppService.Entities;

namespace AppService
{

    
    public interface IPersonService
    {
        Task<List<Person>> GetAllPerson();
        Task<Person> GetPersonByIdAsync(int id);
        Task<Person> AddPersonAsync(Person person);
    }
}
