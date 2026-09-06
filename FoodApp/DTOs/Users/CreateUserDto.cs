using System.ComponentModel.DataAnnotations;

namespace FoodApp.DTOs.Users
{

    public class UserResponseDto : CommonDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? MobileNo { get; set; }
        public int UserRoleId { get; set; }
        public int LoginAttempt { get; set; }
        public bool IsEnable { get; set; }
    }
    public class CreateUserDto : CommonDto
    {
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "User name is required.")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email name is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password name is required.")]
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? MobileNo { get; set; }
        public int UserRoleId { get; set; }
        public int LoginAttempt { get; set; }
        public bool IsEnable { get; set; }
    }



    public class UpdateUserDto : CommonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? MobileNo { get; set; }
        public bool IsEnable { get; set; }
    }
}
