using FoodApp.Data;
using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Users;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace FoodApp.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly FoodAppDBContext _context;

        public UserRepository(FoodAppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
           return await _context.Users.ToListAsync<Users>();
        }

        public async Task<Users?> GetUsersByIDAsync(int Id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
        }
        public async Task<Users> CreateUsers(CreateUserDto createUserDto)
        {
            Users user = new Users
            {
                FirstName = createUserDto.FirstName,
                MiddleName = createUserDto.MiddleName,
                LastName = createUserDto.LastName,
                Username = createUserDto.Username,
                Email = createUserDto.Email,
                Password = createUserDto.Password,
                Address = createUserDto.Address,
                MobileNo = createUserDto.MobileNo,
                UserRoleId = createUserDto.UserRoleId,
                LoginAttempt = createUserDto.LoginAttempt,
                IsEnable = createUserDto.IsEnable,

                IsActive = createUserDto.IsActive,
                CreatedBy = createUserDto.CreatedBy,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now

            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Users> UserUpdateAsync(Users AvablesUser, UpdateUserDto userDto)
        {

            AvablesUser.FirstName = userDto.FirstName;
            AvablesUser.MiddleName = userDto.MiddleName;
            AvablesUser.LastName = userDto.LastName;
            AvablesUser.Username = userDto.Username;
            AvablesUser.Email = userDto.Email;
            AvablesUser.Address = userDto.Address;
            AvablesUser.MobileNo = userDto.MobileNo;
            AvablesUser.IsEnable = userDto.IsEnable;
            AvablesUser.IsActive = userDto.IsActive;
            AvablesUser.UpdatedBy = userDto.UpdatedBy;
            AvablesUser.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return AvablesUser;

        }

        public async Task<Users> UserDelateAsync(Users user)
        {
          
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Users?> UserValidation(string? Email, string? Username, string? MobileNo)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == Email || u.Username == Username || u.MobileNo == MobileNo);
        }

        public async Task<Users?> LoginUser(string? Username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == Username);

        }

    }
}
