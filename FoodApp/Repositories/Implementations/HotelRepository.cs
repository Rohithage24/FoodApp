using FoodApp.Data;
using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Hotels;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace FoodApp.Repositories.Implementations
{
    public class HotelRepository : IHotelRepository
    {
        private readonly FoodAppDBContext _context;

        public HotelRepository(FoodAppDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Hotels>> GetAllHotelsAsync()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotels?> GetHotelsAsync(int id)
        {
            return await _context.Hotels.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<Hotels> CreateHotels(CreateHotelDtos hotels)
        {
            Hotels newHotel = new Hotels
            {
                Name = hotels.Name,
                OwnerName = hotels.OwnerName,
                OwnerIdentity = hotels.OwnerIdentity,
                MobileNo = hotels.MobileNo,
                Email = hotels.Email,
                Password = hotels.Password,
                Ratings = hotels.Ratings,
                Address = hotels.Address,
                Pin = hotels.Pin,
                RoleId = hotels.RoleId,
                IsAvailable = hotels.IsAvailable,
                IsActive = hotels.IsActive,
                CreatedBy = hotels.CreatedBy,
            };
            await _context.Hotels.AddAsync(newHotel);
            await _context.SaveChangesAsync();
            return newHotel;
        }

       public async Task<Hotels?> HotelsLoginAsync(LoginDtos loginDtos)
        {
            return await _context.Hotels.FirstOrDefaultAsync(h=>h.Email == loginDtos.Username);
        }
    }
}
