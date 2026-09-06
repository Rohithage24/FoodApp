using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Hotels;
using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IHotelServices 
    {
        Task<IEnumerable<HotelsResponseDtos>> AllHotelsAsync();
        Task<HotelsResponseDtos> GetHotelsAsync(int id);

        Task<HotelsResponseDtos> CreateHotels(CreateHotelDtos hotels);

        Task<HotelsResponseDtos> UpdateHotelAsync(int  id, UpdateHotelDtos updateHotel);

        Task<HotelsResponseDtos> DeleteHotelAsync(int id);

        Task<HotelsResponseDtos> HotelsLoginAsync(LoginDtos loginDtos);

    }
}
