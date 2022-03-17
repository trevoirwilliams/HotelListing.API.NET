using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Models.Country
{
    public abstract class BaseCountryDto : IBaseDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Id { get; set; }
    }
}
