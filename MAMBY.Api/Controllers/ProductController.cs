using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto product)
        {
            var result = await _productService.AddProduct(product);
            if(result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPut("UpdateProduct")]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProduct(int id)
        {
            var msg = _productService.DeleteProduct(id);
            if (msg == "Ok")
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("GetProductsByCategory/{id}")]
        public async Task<IActionResult> GetProductsByCategory(int id)
        {
            var products = await _productService.GetProductsByCategory(id);
            if(products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
        [HttpGet("GetProductsSearch/{search}")]
        public async Task<IActionResult> GetProductsSearch(string? search)
        {
            var productList = await _productService.GetAllProducts();
            if(search != null)
            {
                productList = productList.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
				return Ok(productList);
			}
            return BadRequest();
		}

        [HttpGet("GetAllFilter")]
        public async Task<IActionResult> GetAllFilter()
        {
            var products = await _productService.GetAllWithCategory();
            if (products == null)
            {
                return BadRequest();
            }
            return Ok(products);
        }
    }
}
