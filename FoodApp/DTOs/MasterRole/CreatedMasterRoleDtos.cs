namespace FoodApp.DTOs.MasterRole
{
    public class CreatedMasterRoleDtos : CommonDto
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public int CreatedRole { get; set; }
    }

    public class UpdateMasterRoleDtos : CommonDto
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public int CreatedRole { get; set; }
    }

    public class ResponsMasterRoleDtos : CommonDto
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public int CreatedRole { get; set; }
    }
}
