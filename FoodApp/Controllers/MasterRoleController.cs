using FoodApp.DTOs.MasterRole;
using FoodApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterRoleController : ControllerBase
    {
        private readonly IMasterRoleServices _services;

        public MasterRoleController(IMasterRoleServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponsMasterRoleDtos>>> GetAllAsunc()
        {
            var result = await _services.GetAllAsunc();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ResponsMasterRoleDtos>> CreatedRoleAsync(CreatedMasterRoleDtos role)
        {
            var result = await _services.CreatedRoleAsync(role);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ResponsMasterRoleDtos>> UpdateRole(int id , [FromBody] UpdateMasterRoleDtos updateRole)
        {
            try
            {
                var result = await _services.UpdateByAsync(id, updateRole);
                return Ok(result);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new {massage = ex.Message});  
            }
            catch(Exception ex)
            {
                return BadRequest(new { massage = ex.Message });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ResponsMasterRoleDtos>> DeleteRole(int id)
        {
            try
            {
                var Result = await _services.DeleteByIdAsync(id);
                return StatusCode(204, Result);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new { massage = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { massage = ex.Message });
            }
        }

    }
}
