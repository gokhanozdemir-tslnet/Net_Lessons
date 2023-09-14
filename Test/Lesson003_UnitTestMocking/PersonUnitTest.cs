

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
using Xunit.Abstractions;
using FluentAssertions.Extensions;

namespace Lesson003_UnitTestMocking
{
    


    public class PersonUnitTest
    {
        private readonly IPersonService _personService;
        private readonly ITestOutputHelper _testOutputHelper;

        public PersonUnitTest(ITestOutputHelper testOutputHelper)
        {

            var personsInitialData = new List<Person> { };

            DbContextMock<AppDbContext> dbContextMock = new DbContextMock<AppDbContext>(new DbContextOptionsBuilder<AppDbContext>().Options);

            AppDbContext dbContext = dbContextMock.Object;
            dbContextMock.CreateDbSetMock(temp => temp.Persons, personsInitialData);

            _personService = new PersonService(dbContext);

            _testOutputHelper = testOutputHelper;
            
            //DbContextMock<AppDbContext>
        }


        [Fact]
        public async Task AddPerson_NullPerson()
        {
            //Arrange
            Person pRequest = null;

            //Act
            _testOutputHelper.WriteLine("Example:");
            Func<Task> action = async () => { await _personService.AddPersonAsync(pRequest); };

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task AddPerson_ProperPerson_ToBeSucces()
        {
            //Arrange
            var fixture = new Fixture();
            Person pRequest = fixture.Build<Person>().With(x=>x.Id,0).Create();
            

            //Act
            Func<Task> action = async () => { await _personService.AddPersonAsync(pRequest); };

            var sonuc = await _personService.AddPersonAsync(pRequest);

            _testOutputHelper.WriteLine(action.ToString());

            sonuc.Should().NotBe(sonuc.Id == 0);            
            
        }

        [Fact]
        public async Task AddPerson_ProperPerson_Performance()
        {
            //Arrange
            var fixture = new Fixture();
            Person pRequest = fixture.Build<Person>().With(x => x.Id, 0).Create();


            //Act
            Func<Task> action = async () => { await _personService.AddPersonAsync(pRequest); };

            var sonuc = await _personService.AddPersonAsync(pRequest);

            _testOutputHelper.WriteLine(action.ToString());

            _personService.ExecutionTimeOf(s => s.AddPersonAsync(pRequest)).Should().BeLessThanOrEqualTo(1.Seconds()); // 1 sec(saniye) = 1000 milisecond


        }


    }

    
}
