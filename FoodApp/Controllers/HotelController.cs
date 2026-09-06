using FoodApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodApp.DTOs.Hotels;
using FoodApp.DTOs.Auth;
using Microsoft.Identity.Client.NativeInterop;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServices _hotelServices;

        public HotelController(IHotelServices hotelServices)
        {
            _hotelServices = hotelServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelsResponseDtos>>> GetAllHotels()
        {
            var hotels = await _hotelServices.AllHotelsAsync();
            return Ok(hotels);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<HotelsResponseDtos>> GetHotelAsync(int id)
        {
            try
            {
                var hotel = await _hotelServices.GetHotelsAsync(id);
                return Ok(hotel);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request.", Error = ex });
            }
        }

        [HttpPost]
        public async Task<ActionResult<HotelsResponseDtos>> CreateHotel(CreateHotelDtos createHotelDto)
        {
            var hotel = await _hotelServices.CreateHotels(createHotelDto);
            return Ok(hotel);
        }

        [HttpPost("login")]
        public async Task<ActionResult<HotelsResponseDtos>> HotelsLogin(LoginDtos loginDtos)
        {
            try
            {
                var hotel = await _hotelServices.HotelsLoginAsync(loginDtos);
                return Ok(hotel);
            }
            catch(KeyNotFoundException ex)
            {
                return BadRequest(new {message = ex.Message});
            }
            catch(UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request." , Error=ex });
            }
        }
    }
}
