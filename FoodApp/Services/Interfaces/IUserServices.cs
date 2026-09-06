using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Users;
using FoodApp.Models;
namespace FoodApp.Services.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<UserResponseDto>> GetAllUsersAsync();

        Task<UserResponseDto> GetUsersByIDAsync(int id);

        Task<UserResponseDto> UserUpdateAsync(int id ,UpdateUserDto users);

        Task<UserResponseDto> CreateUser(CreateUserDto user);

        Task<UserResponseDto> LoginUser(LoginDtos loginDtos);

        Task<UserResponseDto> UserDelateAsync(int id);
    }
}
