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
        Task<Hotels?> HotelsLoginAsync(LoginDtos loginDtos);
    }
}
