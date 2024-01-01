using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IRoleService
    {
        Task<List<RoleDto>> GetAllRoles();
        Task<UsersInOrOutDto> GetAllUsersWithRole(string id);
        Task<RoleDto> FindRoleByIdAsync(string id);
        Task<string> EditRoleListAsync(EditRoleDto model);
    }
}
