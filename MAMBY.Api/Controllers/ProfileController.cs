using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Services;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetByIdUser/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var user = await _userService.GetByIdUser(id);
            if (user == null)
            {
                return BadRequest();
            }
            return Ok(user);
        }
        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfileInformation([FromBody] UpdateUserDto userDto)
        {
            var user = await _userService.UpdateProfileInformation(userDto);
            if (user == null)
            {
                return BadRequest();
            }
            return Ok(user);    
        }
    }
}
