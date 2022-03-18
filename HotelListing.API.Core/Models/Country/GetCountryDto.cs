using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Core.Models.Country
{
    public class GetCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }
}
