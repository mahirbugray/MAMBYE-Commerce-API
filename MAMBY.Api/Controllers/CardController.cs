using Entity.DTOs;
using Entity.Entities;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        [HttpPost("CreateCart")]
        public async Task<IActionResult> CreateCart([FromBody] CardDto model)
        {
            int createCartId = await _cardService.CreateCart(model);
            if(createCartId != 0)
            {
                return Ok(createCartId);
            }
            return BadRequest();
        }
    }
}
