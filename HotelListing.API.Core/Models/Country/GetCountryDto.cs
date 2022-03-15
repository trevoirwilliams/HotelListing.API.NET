using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Core.Models.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }
}
