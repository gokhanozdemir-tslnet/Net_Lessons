
using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface ICountriesService
    {
        CountryAddResponse AddCountry(CountryAddRequest? countryAddRequest);
    }
}
