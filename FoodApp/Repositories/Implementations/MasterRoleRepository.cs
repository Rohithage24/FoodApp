using FoodApp.Data;
using FoodApp.DTOs.MasterRole;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Repositories.Implementations
{
    public class MasterRoleRepository : IMasterRoleRepository
    {
        public readonly FoodAppDBContext _context;

        public MasterRoleRepository(FoodAppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MasterRole>> GetAllAsunc()
        {
            return await _context.MasterRoles.ToListAsync();
        }

        public async Task<MasterRole?> GetByIdAsync(int? Id, string? Role)
        {
            var roleData = await _context.MasterRoles.FirstOrDefaultAsync(u => u.Id == Id || u.RoleName == Role);
            return roleData;
        }

        public async Task<MasterRole> CreatedRoleAsync(CreatedMasterRoleDtos role)
        {
            MasterRole newRole = new MasterRole
            {
                RoleName = role.RoleName,
                CreatedRole = role.CreatedRole,
                CreatedBy = role.CreatedBy,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            await _context.MasterRoles.AddAsync(newRole);
            await _context.SaveChangesAsync();
            return newRole;
        }

        public async Task<MasterRole> UpdateByAsync(MasterRole avaAvablesRole, UpdateMasterRoleDtos UpdateRole)
        {
            avaAvablesRole.RoleName = UpdateRole.RoleName;
            avaAvablesRole.UpdatedBy = UpdateRole.UpdatedBy;
            avaAvablesRole.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return avaAvablesRole;
        }

        public async Task<MasterRole?> DeleteByIdAsync(MasterRole role)
        {

                _context.MasterRoles.Remove(role);
                await _context.SaveChangesAsync();
                return role;
            
        }
    }
}
