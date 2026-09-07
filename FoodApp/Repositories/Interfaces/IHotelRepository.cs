using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Hotels;
using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotels>> GetAllHotelsAsync();
        Task<Hotels?> GetHotelsAsync(int id);
        Task<Hotels> CreateHotels(CreateHotelDtos hotels);

        Task<Hotels> UpdateHotelAsync(Hotels exsitingData, UpdateHotelDtos updateHotel);

        Task<Hotels> DeleteHotelAsync(Hotels hotels);
        Task<Hotels?> HotelsLoginAsync(string? Username);

    }
}
