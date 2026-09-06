using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    [Table("MasterRole")]
    public class MasterRole : Common
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public int CreatedRole { get; set; }
    }
}
