

using AppService.Entities;

namespace RepositoryContracts
{
    public interface IPersonRepository
    {
        Task<Person> AddPerson(Person person);
        Task<Person> UpdatePerson(Person person);
        Task<List<Person>> GetAllPersons();
        Task<Person?> GetPersonByPersonId(int id);
        Task<Person?> GetPersonByPersonName(string name);
    }
}