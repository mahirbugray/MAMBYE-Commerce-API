using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeatureController : ControllerBase
    {
        private readonly IProductFeatureService _productFeatureService;

        public ProductFeatureController(IProductFeatureService productFeatureService)
        {
            _productFeatureService = productFeatureService;
        }

        [HttpGet("GetAllProductFeature/{id}")]
        public async Task<IActionResult> GetAllProductFeature(int id)
        {
            var productFeature = await _productFeatureService.GetAll(id);
            if (productFeature == null)
            {
                return NotFound();
            }
            return Ok(productFeature);
        }
        [HttpPost("AddProductFeature")]
        public async Task<IActionResult> AddProductFeature([FromBody] ProductFeatureDto featureDto)
        {
            var message = await _productFeatureService.Add(featureDto);
            if (message == null)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
