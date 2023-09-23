
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

        public static Person ToPerson(this AddPersonRequest person)
        {
            return new Person
            {
                Name = person.Name,
                Email = person.Email,   
                Address = person.Address,   
                Surname = person.Surname    
            };


            public static AddPersonRequest ToPersonRequest(this Person person)
            {
                return new AddPersonRequest
                {
                    Name = person.Name,
                    Email = person.Email,
                    Address = person.Address,
                    Surname = person.Surname
                };
            }
        }
}
