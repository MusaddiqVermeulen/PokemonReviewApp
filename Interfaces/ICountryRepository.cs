using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnerFromACountry(int countryId);
        bool CountryExists(int Id);
        bool CreateCountry(Country country);  // creating our signatures(create methods)
        bool UpdateCountry(Country country);  // updating and changing names
        bool DeleteCountry(Country country);  // used for deleting
        bool Save();
    }
}
