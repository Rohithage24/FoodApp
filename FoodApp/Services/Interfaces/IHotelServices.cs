using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Hotels;

namespace FoodApp.Services.Interfaces
{
    public interface IHotelServices 
    {
        Task<IEnumerable<HotelsResponseDtos>> AllHotelsAsync();
        Task<HotelsResponseDtos> GetHotelsAsync(int id);

        Task<HotelsResponseDtos> CreateHotels(CreateHotelDtos hotels);

        Task<HotelsResponseDtos> HotelsLoginAsync(LoginDtos loginDtos);

    }
}
