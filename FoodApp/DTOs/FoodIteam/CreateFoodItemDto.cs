namespace FoodApp.DTOs.FoodIteam
{
    public class CreateFoodItemDto : CommonDto
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; } = 0;
        public string? Hoteial { get; set; }
        public int Rateing { get; set; }
        public bool? Veg { get; set; } = true;
        public string Desc { get; set; } = "";
    }


    public class RespoFoodIteam
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; } = 0;
        public string? Hoteial { get; set; }
        public int Rateing { get; set; }
        public bool? Veg { get; set; } = true;
        public string Desc { get; set; } = "";
    }

    public class UpdateFoodIteam : CommonDto
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? Price { get; set; } = 0;
        public string? Hoteial { get; set; }
        public int Rateing { get; set; }
        public bool? Veg { get; set; } = true;
        public string Desc { get; set; } = "";
    }
}
