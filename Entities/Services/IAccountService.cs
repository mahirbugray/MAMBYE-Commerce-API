using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IAccountService
    {
        Task<string> RegisterAsync(RegisterDto model);
        Task<UserDto> Login(LoginDto model);
        Task LogoutAsync();
        Task<string> ResetPassword(PasswordResetDto model);
        Task<string> ResetPasswordControl(string username);
		//Task<PasswordResetDto> FindUser(PasswordResetDto model);

	}
}
