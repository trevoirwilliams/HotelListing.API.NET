using HotelListing.API.NET5.Data;
using System.Threading.Tasks;

namespace HotelListing.API.NET5.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
