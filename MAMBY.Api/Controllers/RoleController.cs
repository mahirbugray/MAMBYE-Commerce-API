using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace MAMBY.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleService.GetAllRoles();
            if (roles == null || roles.Count == 0)
            {
                return NotFound();
            }
            return Ok(roles);
        }

        [HttpGet("GetEditRole/{id}")]
        public async Task<IActionResult> EditRole(string id)
        {
            var model = await _roleService.GetAllUsersWithRole(id);
            if (model == null)
            {
                return BadRequest();
            }
            return Ok(model);
        }
        [HttpPost("PostEditRole")]
        public async Task<IActionResult> EditRole([FromBody] EditRoleDto role)
        {
            string msg = await _roleService.EditRoleListAsync(role);
            if (msg != "OK")
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
