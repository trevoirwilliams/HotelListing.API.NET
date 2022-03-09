using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.NET5.Models.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }
}
