using HotelListing.Api.Common.Results;
using HotelListing.Api.Application.DTOs.Auth;

namespace HotelListing.Api.Application.Contracts
{
    public interface IUsersService
    {
        string UserId { get; }
        Task<Result<string>> LoginAsync(LoginUserDto dto);
        Task<Result<RegisteredUserDto>> RegisterAsync(RegisterUserDto registerUserDto);
    }
}