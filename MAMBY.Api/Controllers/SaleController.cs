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
            return Ok(sales);
        }
        [HttpGet("GetSaleById")]
        public async Task<IActionResult> GetSaleById(int id)
        {
            var sale = await _saleService.GetById(id);
            return Ok(sale);
        }
        [HttpGet("DeleteSale")]
        public IActionResult DeleteSale(int id)
        {
            _saleService.Delete(id);
            return Ok();
        }
        [HttpPost("CreateSale")]
        public async Task<IActionResult> CreateSale(SaleDto saleDto)
        {
            var sale = await _saleService.Create(saleDto);
            return Ok(sale);
        }
    }
}
