using FoodApp.DTOs.Auth;
using FoodApp.DTOs.Hotels;
<<<<<<< HEAD
using FoodApp.Models;
=======
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329

namespace FoodApp.Services.Interfaces
{
    public interface IHotelServices 
    {
        Task<IEnumerable<HotelsResponseDtos>> AllHotelsAsync();
        Task<HotelsResponseDtos> GetHotelsAsync(int id);

        Task<HotelsResponseDtos> CreateHotels(CreateHotelDtos hotels);

<<<<<<< HEAD
        Task<HotelsResponseDtos> UpdateHotelAsync(int  id, UpdateHotelDtos updateHotel);

        Task<HotelsResponseDtos> DeleteHotelAsync(int id);

=======
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329
        Task<HotelsResponseDtos> HotelsLoginAsync(LoginDtos loginDtos);

    }
}
