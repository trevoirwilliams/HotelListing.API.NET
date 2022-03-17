using HotelListing.API.Core.Models.Hotel;

namespace HotelListing.API.Core.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public List<HotelDto> Hotels { get; set; }
    }
}
