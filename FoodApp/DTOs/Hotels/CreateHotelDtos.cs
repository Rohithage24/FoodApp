namespace FoodApp.DTOs.Hotels
{
    public class CreateHotelDtos : CommonDto
    {
<<<<<<< HEAD

=======
        public int Id { get; set; }
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329
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
<<<<<<< HEAD
=======
        public int Id { get; set; }
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329
        public string? Name { get; set; }
        public string? OwnerName { get; set; }
        public string OwnerIdentity { get; set; } = string.Empty;
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
<<<<<<< HEAD
        public string? Address { get; set; }
        public int? Pin { get; set; }
=======
        public int Ratings { get; set; }
        public string? Address { get; set; }
        public int? Pin { get; set; }
        public int RoleId { get; set; }
>>>>>>> 8432a33b83dcbe1aea3b13fdd7be926f31355329
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
