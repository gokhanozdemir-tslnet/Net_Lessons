
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
                PersonID = person.PersonID,
                PersonName = person.PersonName,
                Address = person.Address,
                CountryID = person.CountryID,
                DateOfBirth = person.DateOfBirth,
                Email = person.Email,
                Gender = person.Gender,
                ReceiveNewsLetters = person.ReceiveNewsLetters  
            };
        }
    }
}
