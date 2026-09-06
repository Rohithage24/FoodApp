using FoodApp.DTOs.MasterRole;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class MasterRoleServices : IMasterRoleServices
    {
        private readonly IMasterRoleRepository _masterRoleRepository;

        public MasterRoleServices(IMasterRoleRepository masterRoleRepository) 
        {
            _masterRoleRepository = masterRoleRepository;
        }

        public async Task<IEnumerable<ResponsMasterRoleDtos>> GetAllAsunc()
        {
            var masterRoles = await _masterRoleRepository.GetAllAsunc();
            var responseDtos = masterRoles.Select(role => new ResponsMasterRoleDtos
            {
                Id = role.Id,
                RoleName = role.RoleName,
                CreatedRole = role.CreatedRole,
                IsActive = true,
                CreatedBy = role.CreatedBy,
                CreatedDate= role.CreatedDate,
                UpdatedBy = role.UpdatedBy,
                UpdatedDate= role.UpdatedDate
            });
            return responseDtos;
        }

        public async Task<ResponsMasterRoleDtos> CreatedRoleAsync(CreatedMasterRoleDtos role)
        {
            var createdRole = await _masterRoleRepository.CreatedRoleAsync(role);

            return new ResponsMasterRoleDtos
            {
                Id = role.Id,
                RoleName = role.RoleName,
                CreatedRole = role.CreatedRole,
                IsActive = role.IsActive,
                CreatedBy = role.CreatedBy,
                CreatedDate = role.CreatedDate,
                UpdatedBy = role.UpdatedBy,
                UpdatedDate = role.UpdatedDate
            };
        }

        public async Task<ResponsMasterRoleDtos> UpdateByAsync(int id, UpdateMasterRoleDtos UpdateRole)
        {
            var role = await _masterRoleRepository.GetByIdAsync(id, null);
            if(role == null)
            {
                throw new KeyNotFoundException($"Role with ID {id} not found.");
            }

           var Updaterole = await _masterRoleRepository.UpdateByAsync(role, UpdateRole);
            return new ResponsMasterRoleDtos
            {
                Id = Updaterole.Id,
                RoleName = Updaterole.RoleName,
                CreatedRole = Updaterole.CreatedRole,
                IsActive = Updaterole.IsActive,
                CreatedBy = Updaterole.CreatedBy,
                CreatedDate = Updaterole.CreatedDate,
                UpdatedBy = Updaterole.UpdatedBy,
                UpdatedDate = Updaterole.UpdatedDate
            };
        }

        public async Task<ResponsMasterRoleDtos?> DeleteByIdAsync(int Id)
        {
            var role = await _masterRoleRepository.GetByIdAsync(Id, null);
            if(role == null)
            {
                throw new KeyNotFoundException($"Role with ID {Id} not found.");
            }

            var result = await _masterRoleRepository.DeleteByIdAsync(role);
            return new ResponsMasterRoleDtos
            {
                Id = result.Id,
                RoleName = result.RoleName,
                CreatedRole = result.CreatedRole,
                IsActive = result.IsActive,
                CreatedBy = result.CreatedBy,
                CreatedDate = result.CreatedDate,
                UpdatedBy = result.UpdatedBy,
                UpdatedDate = result.UpdatedDate

            };
        }
    }
}
