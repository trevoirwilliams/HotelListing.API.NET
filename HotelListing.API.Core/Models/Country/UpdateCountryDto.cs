namespace HotelListing.API.Core.Models.Country
{
    public class UpdateCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }
}
