
using AppService;
using AppService.Dtos;
using AppService.Entities;
using AutoFixture;

using FluentAssertions;
using Moq;
using RepositoryContracts;
using Xunit;


namespace Lesson004_UnittestMockRepository
{
    public class PersonUnitTest 
    {
        private readonly PersonService.PersonService _personservice;
        private readonly IPersonRepository _personRepository;
        private readonly Mock<IPersonRepository> _personRepositoryMock;
        private readonly Fixture _fixture;
        public PersonUnitTest()
        {
            _personRepositoryMock = new Mock<IPersonRepository>();
            _personRepository = _personRepositoryMock.Object;
            _personservice = new PersonService.PersonService(_personRepository);
            _fixture = new Fixture();
        }



        [Fact]
        public async void AddPerson_ProperPerson_ToBeSucced()
        {
            
            //Arrange
            Person person_response_expected = _fixture.Build<Person>().Create();
            
            AddPersonRequest person_request = person_response_expected.ToPersonRequest();

            _personRepositoryMock.Setup(temp => temp.AddPerson(It.IsAny<AddPersonRequest>()))
                .ReturnsAsync();


        }
    }
}