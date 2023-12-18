using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        [HttpGet("GetAllSale")]
        public async Task<IActionResult> GetAllSale()
        {
            var sales = await _saleService.GetAll();
            if (sales == null)
            {
                return NotFound();
            }
            return Ok(sales);
        }
        [HttpGet("GetSaleById")]
        public async Task<IActionResult> GetSaleById(int id)
        {
            var sale = await _saleService.GetById(id);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }
        [HttpGet("DeleteSale")]
        public IActionResult DeleteSale(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                _saleService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

               return BadRequest(ex.Message);
            }
           
          
        }
        [HttpPost("CreateSale")]
        public async Task<IActionResult> CreateSale(SaleDto saleDto)
        {
            var sale = await _saleService.Create(saleDto);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }
    }
}
