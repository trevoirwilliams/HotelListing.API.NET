using HotelListing.API.Core.Models.Users;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace HotelListing.API.Core.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
