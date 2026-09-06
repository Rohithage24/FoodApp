using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Users;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return users.Select(user=> new UserResponseDto { 
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.Username,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable
            });
        }

        public async Task<UserResponseDto> GetUsersByIDAsync(int id)
        {
            var user = await _userRepository.GetUsersByIDAsync(id);

            if(user == null)
            {
                throw new KeyNotFoundException("User not found");
            }
            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,

            };
        }
        public async Task<UserResponseDto> CreateUser(CreateUserDto createUserDto)
        {
            var Validation = await _userRepository.UserValidation(createUserDto.Email, createUserDto.Username, createUserDto.MobileNo);
            if (Validation != null)
            {
                throw new InvalidOperationException("Email, Username or MobileNo already exists.");
            }

            var user =await _userRepository.CreateUsers(createUserDto);

            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,

            };
        }

        public async Task<UserResponseDto> UserUpdateAsync(int id , UpdateUserDto UserDto)
        {
            var userAvable = await _userRepository.GetUsersByIDAsync(id);
            if (userAvable == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            var Validation = await _userRepository.UserValidation(UserDto.Email, UserDto.Username, UserDto.MobileNo);
            if(Validation != null && Validation?.Id != id)
            {
                throw new InvalidOperationException("Email, Username or MobileNo already exists.");
            }

            var user = await _userRepository.UserUpdateAsync(userAvable, UserDto);

            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,

            };
        }

        public async Task<UserResponseDto> UserDelateAsync(int id)
        {
            var user = await _userRepository.GetUsersByIDAsync(id);
            if(user == null)
            {
                throw new KeyNotFoundException("User not found");
            }

             user = await _userRepository.UserDelateAsync(user);
            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,

            };
        }
        public async Task<UserResponseDto> LoginUser(LoginDtos loginDtos)
        {
            var user = await _userRepository.LoginUser(loginDtos.Username);

            if (user == null)
            {
                throw new KeyNotFoundException("User not found.");
            }


            if (user.Password != loginDtos.Password)
            {
                throw new UnauthorizedAccessException("Password does not match.");
            }

            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Address = user.Address,
                MobileNo = user.MobileNo,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,
            };
        }

    }
}
