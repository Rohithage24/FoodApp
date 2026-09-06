using FoodApp.DTOs.MasterRole;

namespace FoodApp.Services.Interfaces
{
    public interface IMasterRoleServices
    {
        Task<IEnumerable<ResponsMasterRoleDtos>> GetAllAsunc();

        Task<ResponsMasterRoleDtos> CreatedRoleAsync(CreatedMasterRoleDtos role);

        Task<ResponsMasterRoleDtos> UpdateByAsync(int id, UpdateMasterRoleDtos UpdateRole);

        Task<ResponsMasterRoleDtos?> DeleteByIdAsync(int Id);
    }
}
