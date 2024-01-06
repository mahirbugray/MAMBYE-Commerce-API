using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using System.Security.Claims;

namespace MAMBY.Api.Controllers
{
    [Authorize(Roles ="Kullanıcı,Admin")]
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
        [HttpDelete("DeleteSale")]
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
        public async Task<IActionResult> CreateSale([FromBody]PaymentPostDto model)
        {
            var userIdClaim = User.FindFirst(x => x.Type == ClaimTypes.UserData);
            if (userIdClaim != null)
            {
                int userId = Convert.ToInt32(userIdClaim.Value);
                var sale = await _saleService.Create(model, userId);
                if (sale == null)
                {
                    return NotFound();
                }
                return Ok();
            }
            return BadRequest();
        }
        //[HttpGet]
        //public async Task<IActionResult> ReceiptSale(int id)
        //{
        //    var userIdClaim = User.FindFirst(ClaimTypes.UserData);
        //    if (userIdClaim == null)
        //    {
        //        return BadRequest("");
        //    }
        //    int userId = Convert.ToInt32(userIdClaim.Value);

        //    var lastSale = await _saleService.GetById(id);
        //    if (lastSale != null)
        //    {
        //        return Ok(lastSale);
        //    }
        //    return NotFound();
        //}
    }
}
