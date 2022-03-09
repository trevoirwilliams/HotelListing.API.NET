using HotelListing.API.NET5.Models.Hotel;

namespace HotelListing.API.NET5.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
