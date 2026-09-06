using FoodApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    public class FoodAppDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<MasterRole> MasterRoles { get; set; }
        public FoodAppDBContext(DbContextOptions<FoodAppDBContext> options) : base(options)
        {
        }

    }
}

