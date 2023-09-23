using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
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
