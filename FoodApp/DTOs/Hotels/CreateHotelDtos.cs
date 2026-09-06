namespace FoodApp.DTOs.Hotels
{
    public class CreateHotelDtos : CommonDto
    {

        public string? Name { get; set; }
        public string? OwnerName { get; set; }
        public string OwnerIdentity { get; set; } = string.Empty;
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Ratings { get; set; }
        public string? Address { get; set; }
        public int? Pin { get; set; }
        public int RoleId { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    public class UpdateHotelDtos : CommonDto
    {
        public string? Name { get; set; }
        public string? OwnerName { get; set; }
        public string OwnerIdentity { get; set; } = string.Empty;
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int? Pin { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    public class HotelsResponseDtos 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? OwnerName { get; set; }
        public string OwnerIdentity { get; set; } = string.Empty;
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public int Ratings { get; set; }
        public string? Address { get; set; }
        public int? Pin { get; set; }
        public int RoleId { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
