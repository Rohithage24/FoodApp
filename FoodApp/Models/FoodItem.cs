using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    [Table("FoodItem")]
    public class FoodItem : Common
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; } = 0;
        public string? Hoteial { get; set; }
        public int Rateing { get; set; }
        public bool? Veg { get; set; } = true;
        public string Desc { get; set; } = "";



    }
}
