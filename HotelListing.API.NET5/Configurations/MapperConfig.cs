using AutoMapper;
using HotelListing.API.NET5.Data;
using HotelListing.API.NET5.Models.Country;
using HotelListing.API.NET5.Models.Hotel;

namespace HotelListing.API.NET5.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();

        }
    }
}
