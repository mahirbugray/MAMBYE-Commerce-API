﻿using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommandService _commandService;

        public CommandController(ICommandService commandService)
        {
            _commandService = commandService;
        }
        [HttpPost("AddCommand")]
        public async Task<IActionResult> AddCommand([FromBody] CommandDto commandDto)
        {
            var msg = await _commandService.AddCommand(commandDto);
            if (msg == "OK") 
            {
                return Ok();
            }
            return BadRequest(msg);
        }
       
        [HttpPut("UpdateCommand")]
        public async Task<IActionResult> UpdateCommand(CommandDto commandDto)
        {
            var command = await _commandService.UpdateCommand(commandDto);
            if (command == "OK")
            {
                return Ok();
            }
            return BadRequest(command);
        }
    }
}
