

using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries;

        public CountriesService()
        {
            _countries = new List<Country>();
        }

        public CountryAddResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            //Validation
            if (countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }
            if (countryAddRequest.CountryName == null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }
            if (_countries.Where(temp => temp.CountryName ==
                countryAddRequest.CountryName).Count() > 0
            )
            {
                throw new ArgumentException("Given country name already exists");
            }

            //Convert object from CountryAddRequest
            Country country = countryAddRequest.ToCountry();
            country.CountryId = Guid.NewGuid();
            _countries.Add(country);

            return country.ToCountryResponse();
        }
    }
}
