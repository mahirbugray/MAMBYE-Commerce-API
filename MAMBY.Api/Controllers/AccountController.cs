using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var user = await _accountService.Login(model);
            if (user == null)
            {
                return NotFound("Kullanıcı adınız ya da şifreniz hatalı!!!");
            }
            return Ok(user);
        }

        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync();
            return Ok();
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            string msg = await _accountService.RegisterAsync(model);
            if (msg == "OK")
            {
                return Ok();
            }
            else
            {
                return BadRequest(msg);
            }
        }

        [HttpPost("PasswordResetControl")]
        public async Task<IActionResult> PasswordResetControl([FromBody] string username)
        {
            string token = await _accountService.ResetPasswordControl(username);
            return Ok(token);
        }

		[HttpPost("PasswordReset")]
        public async Task<IActionResult> PasswordReset([FromBody] PasswordResetDto model)
        {
            string msg = await _accountService.ResetPassword(model);
            if (msg == "OK")
            {
                return Ok();
            }
            return BadRequest(msg);
        }
    }
}
