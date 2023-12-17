using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IUserService
    {
        Task<UserDto> GetByIdUser(int id);
        Task<string> UpdateProfileInformation(UpdateUserDto model);
    }
}
