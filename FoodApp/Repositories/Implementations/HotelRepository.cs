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


        public async Task<Hotels> UpdateHotelAsync(Hotels exsitingData, UpdateHotelDtos updateHotel)
        {
            exsitingData.Name = updateHotel.Name;
            exsitingData.OwnerName= updateHotel.OwnerName;
            exsitingData.OwnerIdentity= updateHotel.OwnerIdentity;
            exsitingData.MobileNo= updateHotel.MobileNo;
            exsitingData.Email= updateHotel.Email;
            exsitingData.Address= updateHotel.Address;
            exsitingData.Pin= updateHotel.Pin;
            exsitingData.IsAvailable= updateHotel.IsAvailable;

            await _context.SaveChangesAsync();
            return exsitingData;
        }

        public async Task<Hotels> DeleteHotelAsync(Hotels hotels)
        {
             _context.Hotels.Remove(hotels);
            await _context.SaveChangesAsync();
            return hotels;
        }


        public async Task<Hotels?> HotelsLoginAsync(string? Username)
        {
            return await _context.Hotels.FirstOrDefaultAsync(h=>h.Email == Username);

        }
    }
}
