using CampusLove.Domain.Entities;
using CampusLove.Domain.Ports;

namespace CampusLove.Domain.Interfaces
{
    public interface IAddressesRepository : IGenericRepository<Addresses>
    {
        Addresses Create(Addresses newAddress);
        IEnumerable<Addresses> GetAll();
        Addresses GetById(int id);
        IEnumerable<Country> GetAllCountries();
        IEnumerable<States> GetStatesByCountry(int id_country);
        IEnumerable<Cities> GetCitiesByState(int id_state);
        Addresses? BuscarDireccion(int id_city, string street_number, string street_name);
        Cities GetCityById(int id);
        States GetStateById(int id);
        Country GetCountryById(int id);
    }
}
