
using ServiceContracts;
using ServiceContracts.DTO;
using Services;
using System;
using Xunit;

namespace Lesson002_CRUDTests
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;

        public CountriesServiceTest()
        {
            _countriesService = new CountriesService();
        }

        //When CountryAddRequest is null, it should ArgumentNullException
        [Fact]
        public void AddCountry_NullCountry() //name: MethodName_Testscenarioname
        {
            //Arrange
            CountryAddRequest request = null;

            //Assert
            Assert.Throws<ArgumentNullException>(
                //Act
                () => _countriesService.AddCountry(request)
                );

        }

        //When CountryName is null , it should throw ArgumentException
        [Fact]
        public void AddCountry_CountryIsNull() //name: MethodName_Testscenarioname
        {
            //Arrange
            CountryAddRequest request = new CountryAddRequest
            {
                CountryName = null
            };

            //Assert
            Assert.Throws<ArgumentException>(
                //Act
                () => _countriesService.AddCountry(request)
                );

        }

        //When the CountryName isdublicate ,t sshould throw ArgumentException
        [Fact]
        public void AddCountry_DuplicateCountryName() //name: MethodName_Testscenarioname
        {
            //Arrange
            CountryAddRequest request1 = new CountryAddRequest
            {
                CountryName = "USA"
            };
            CountryAddRequest request2 = new CountryAddRequest
            {
                CountryName = "USA"
            };

            //Assert
            Assert.Throws<ArgumentException>(
                //Act
                () =>
                {
                    _countriesService.AddCountry(request1);
                    _countriesService.AddCountry(request2);
                }
                );

        }

        //When you supply proper coountry name, it should insert
        [Fact]
        public void AddCountry_ProperCountryDetails() //name: MethodName_Testscenarioname
        {
            //Arrange
            CountryAddRequest request1 = new CountryAddRequest
            {
                CountryName = "TURKEY"
            };


            //Act
            CountryAddResponse response = _countriesService.AddCountry(request1);
            
            //Assert
            Assert.True(response.CountryId != Guid.Empty);
        }
    }
}
