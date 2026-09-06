using FoodApp.DTOs.MasterRole;
using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IMasterRoleRepository
    {
        Task<IEnumerable<MasterRole>> GetAllAsunc();

        Task<MasterRole?> GetByIdAsync(int? Id , string? role);
        Task<MasterRole> CreatedRoleAsync(CreatedMasterRoleDtos role);

        Task<MasterRole> UpdateByAsync(MasterRole avaAvablesRole, UpdateMasterRoleDtos UpdateRole );

        Task<MasterRole?> DeleteByIdAsync(MasterRole role);
    }
}
