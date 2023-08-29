

using AppService;
using AppService.DbContexts;
using AppService.Entities;
using System.Collections.Generic;
using Xunit;

using EntityFrameworkCoreMock;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using FluentAssertions;
using AutoFixture;

namespace Lesson003_UnitTestMocking
{
    


    public class PersonUnitTest
    {
        private readonly IPersonService _personService;

        public PersonUnitTest()
        {

            var personsInitialData = new List<Person> { };

            DbContextMock<AppDbContext> dbContextMock = new DbContextMock<AppDbContext>(new DbContextOptionsBuilder<AppDbContext>().Options);

            AppDbContext dbContext = dbContextMock.Object;
            dbContextMock.CreateDbSetMock(temp => temp.Persons, personsInitialData);

            _personService = new PersonService(dbContext);
            
            //DbContextMock<AppDbContext>
        }


        [Fact]
        public async Task AddPerson_NullPerson()
        {
            //Arrange
            Person pRequest = null;

            //Act
            Func<Task> action = async () => { await _personService.AddPersonAsync(pRequest); };

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task AddPerson_ProperPersonalue()
        {
            //Arrange
            var fixture = new Fixture();
            Person pRequest = fixture.Create<Person>();

            //Act
            Func<Task> action = async () => { await _personService.AddPersonAsync(pRequest); };

            await action.Should().;
        }


    }

    
}
