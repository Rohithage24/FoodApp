using FoodApp.Services.Interfaces;
using FoodApp.Repositories.Interfaces;
using FoodApp.DTOs.Hotels;
using FoodApp.DTOs.Auth;

namespace FoodApp.Services.Implementations
{
    public class HotelServices : IHotelServices
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelServices(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<HotelsResponseDtos>> AllHotelsAsync()
        {
            var hotels = await _hotelRepository.GetAllHotelsAsync();
            return hotels.Select(hotel => new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId = hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            });
        }

        public async Task<HotelsResponseDtos> GetHotelsAsync(int id)
        {
            var hotel = await _hotelRepository.GetHotelsAsync(id);

            if(hotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }
            return new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId= hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            };
        }
        public async Task<HotelsResponseDtos> CreateHotels(CreateHotelDtos hotels)
        {
            var hotel = await _hotelRepository.CreateHotels(hotels);
            return new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId = hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            };
        }

<<<<<<< HEAD
        public async Task<HotelsResponseDtos> UpdateHotelAsync(int id, UpdateHotelDtos updateHotel)
        {
            var exhotel = await _hotelRepository.GetHotelsAsync(id);

            if(exhotel == null)
            {
                throw new KeyNotFoundException("Hotel not Found");
            }

            var hotel = await _hotelRepository.UpdateHotelAsync(exhotel , updateHotel);
            return new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId = hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            };


        }

        public async Task<HotelsResponseDtos> DeleteHotelAsync(int id)
        {
            var hotel = await _hotelRepository.GetHotelsAsync(id);

            if (hotel == null)
            {
                throw new KeyNotFoundException("Hotel not Found");
            }

            hotel = await _hotelRepository.DeleteHotelAsync(hotel);
            return new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId = hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            };


        }

        public async Task<HotelsResponseDtos> HotelsLoginAsync(LoginDtos loginDtos)
        {
            var hotel = await _hotelRepository.HotelsLoginAsync(loginDtos.Username);
=======
        public async Task<HotelsResponseDtos> HotelsLoginAsync(LoginDtos loginDtos)
        {
            var hotel = await _hotelRepository.HotelsLoginAsync(loginDtos);
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329

            if (hotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }

            if (hotel.Password != loginDtos.Password)
            {
                throw new UnauthorizedAccessException("Invalid password");
            }

            return new HotelsResponseDtos
            {
                Id = hotel.Id,
                Name = hotel.Name,
                OwnerName = hotel.OwnerName,
                OwnerIdentity = hotel.OwnerIdentity,
                MobileNo = hotel.MobileNo,
                Email = hotel.Email,
                Ratings = hotel.Ratings,
                Address = hotel.Address,
                Pin = hotel.Pin,
                RoleId = hotel.RoleId,
                IsAvailable = hotel.IsAvailable
            };
        }
    }
}
