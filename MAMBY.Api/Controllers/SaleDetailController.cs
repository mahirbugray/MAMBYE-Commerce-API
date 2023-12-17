using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailController : ControllerBase
    {
        private readonly ISaleDetailService _saleDetailService;

        public SaleDetailController(ISaleDetailService saleDetailService)
        {
            _saleDetailService = saleDetailService;
        }
        [HttpGet("GetAllSaleDetail")]
        public async Task<IActionResult> GetAllSaleDetail(int saleId)
        {
            var saleDetails = await _saleDetailService.GetAllSaleDetail(saleId);
            return Ok(saleDetails);
        }
        [HttpGet("GetSaleDetailById")]
        public async Task<IActionResult> GetSaleDetailById(int saleDetailId)
        {
            var saleDetail = await _saleDetailService.GetSaleDetailById(saleDetailId);
            return Ok(saleDetail);
        }
        [HttpPost("CreateSaleDetail")]
        public async Task<IActionResult> CreateSaleDetail(SaleDetailDto saleDetailDto)
        {
            var saleDetail = await _saleDetailService.CreateSaleDetail(saleDetailDto);
            return Ok(saleDetail);
        }
    }
}
