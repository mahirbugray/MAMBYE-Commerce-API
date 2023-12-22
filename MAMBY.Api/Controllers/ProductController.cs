using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto product)
        {
            var result = await _productService.AddProduct(product);
            return Ok(result);
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] ProductDto productDto)
        {
            var product = _productService.UpdateProduct(productDto);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var msg = _productService.DeleteProduct(id);
            if (msg == "Ok")
            {
                return Ok();
            }
            return NotFound();
        }



    }
}
