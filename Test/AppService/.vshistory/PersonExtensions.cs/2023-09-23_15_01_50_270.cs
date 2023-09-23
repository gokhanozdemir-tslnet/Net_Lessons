
using AppService.Dtos;
using AppService.Entities;

namespace AppService
{
    public static class PersonExtensions
    {
        public static AddPersonResponse ToPersonResponse(this Person person)
        {
            return new AddPersonResponse
            {
                Id = person.Id,
                Name = person.Name,
                Email = person.Email,
                Address = person.Address,
                Surname = person.Surname    
            };
        }
    }
}
