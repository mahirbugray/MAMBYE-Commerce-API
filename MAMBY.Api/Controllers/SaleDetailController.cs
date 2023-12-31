﻿using Entity.DTOs;
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
            if (saleDetails == null)
            {
                return NotFound();
            }
            return Ok(saleDetails);
        }
        [HttpGet("GetSaleDetailById")]
        public async Task<IActionResult> GetSaleDetailById(int saleDetailId)
        {
            var saleDetail = await _saleDetailService.GetSaleDetailById(saleDetailId);
            if(saleDetail == null)
            {
                return NotFound();
            }
            return Ok(saleDetail);
        }
        [HttpPost("CreateSaleDetail")]
        public async Task<IActionResult> CreateSaleDetail(SaleDetailDto saleDetailDto)
        {
            var saleDetail = await _saleDetailService.CreateSaleDetail(saleDetailDto);
            if (saleDetail == null) 
            { 
                return NotFound(); 
            }
            return Ok(saleDetail);
        }

        [HttpGet("GetSaleDetail/{id}")]
        public async Task<IActionResult> GetSaleDetail(int id)
        { 
            var list = await _saleDetailService.GetAllSale(id);
            if (list == null)
            {
                return BadRequest();
            }
            return Ok(list);
        }
    }
}
