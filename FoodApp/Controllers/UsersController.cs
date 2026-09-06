using FoodApp.Services.Interfaces;
using FoodApp.DTOs.Users;
using FoodApp.DTOs.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponseDto>>> GetAllUsers()
        {
            var users = await _userServices.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserResponseDto>> GetUserAsync(int id)
        {
            try
            {
                var user = await _userServices.GetUsersByIDAsync(id);
                return Ok(user);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new {massage =  ex.Message});
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserResponseDto>> CreateUser(CreateUserDto createUserDto)
        {
            try
            {
                var user = await _userServices.CreateUser(createUserDto);
                return Ok(user);
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { massage = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { massage = ex.Message });
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<UserResponseDto>> UserUpdateAsync(int id , [FromBody]UpdateUserDto UserDto)
        {
            try
            {
                var user = await _userServices.UserUpdateAsync(id, UserDto);
                return Ok(user);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new { massage = ex.Message });
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { massage = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { massage = ex.Message });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<UserResponseDto>> UserDelateAsync(int id)
        {
            try
            {
                var user = await _userServices.UserDelateAsync(id);
                return StatusCode(204 , user);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserResponseDto>> LoginUser(LoginDtos loginDtos)
        {
            try
            {
                var user = await _userServices.LoginUser(loginDtos);
                return Ok(user);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500 , new { message = ex.Message });
            }
        }
    }
}
