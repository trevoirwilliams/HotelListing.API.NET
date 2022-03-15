using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Core.Models.Country;
using HotelListing.API.Core.Models.Hotel;
using HotelListing.API.Core.Models.Users;

namespace HotelListing.API.Core.Configurations
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
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();   
        }
    }
}
