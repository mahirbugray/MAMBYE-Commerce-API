using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _categoryService.GetAllCategory();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpGet("DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                if(id == 0)
                {
                    return NotFound();
                }
                _categoryService.DeleteCategory(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryDto categoryDto)
        {
            var category = await _categoryService.CreateCategory(categoryDto);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryDto categoryDto)
        {
            var category = await _categoryService.UpdateCategory(categoryDto);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
