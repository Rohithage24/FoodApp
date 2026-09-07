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
<<<<<<< HEAD

        Task<Hotels> UpdateHotelAsync(Hotels exsitingData, UpdateHotelDtos updateHotel);

        Task<Hotels> DeleteHotelAsync(Hotels hotels);
        Task<Hotels?> HotelsLoginAsync(string? Username);
=======
        Task<Hotels?> HotelsLoginAsync(LoginDtos loginDtos);
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329
    }
}
