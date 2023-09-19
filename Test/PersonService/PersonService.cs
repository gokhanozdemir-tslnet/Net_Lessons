using AppService.Entities;
using RepositoryContracts;

namespace PersonService
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> AddPerson(Person person)
        {

            if (person is  null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            if (person.Name is null)
            {
                throw new ArgumentException(nameof(person.Name));
            }
            if (await _personRepository.GetPersonByPersonName(person.Name)!=null)
            {
                throw new ArgumentException("Given person name already exsts");
            }

            return await _personRepository.AddPerson(person);
        }
    }
}