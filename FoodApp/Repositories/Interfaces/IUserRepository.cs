using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Users;
using FoodApp.Models;
namespace FoodApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();

        Task<Users?> GetUsersByIDAsync(int Id);

        Task<Users> CreateUsers(CreateUserDto users);

        Task<Users> UserUpdateAsync(Users AvablesUser ,UpdateUserDto userDto);

        Task<Users?> LoginUser(string? Username);

        Task<Users> UserDelateAsync(Users users);

        Task<Users?> UserValidation(string? Email , string? Username , string? MobileNo);
    }
}
