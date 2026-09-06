namespace FoodApp.DTOs
{
    public class CommonDto
    {
        // Audit variable
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } 
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; } 
    }
}
