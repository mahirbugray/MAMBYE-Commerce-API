﻿using Entity.DTOs;
using Entity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAMBY.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }
        [HttpGet("GetAllCoupons")]
        public async Task<IActionResult> GetAllCoupons()
        {
            var coupons = await _couponService.GetAllCoupons();
            return Ok(coupons);
        }
        [HttpGet("GetCoupon")]
        public async Task<IActionResult> GetCoupon(int id)
        {
            var coupon = await _couponService.GetCouponById(id);
            return Ok(coupon);
        }
        [HttpPost("CreateCoupon")]
        public async Task<IActionResult> CreateCoupon(CouponDto couponDto)
        {
            var coupon = await _couponService.CreateCoupon(couponDto);
            return Ok(coupon);
        }
        [HttpPut("UpdateCoupon")]
        public async Task<IActionResult> UpdateCoupon(CouponDto couponDto)
        {
            var coupon = await _couponService.UpdateCoupon(couponDto);
            return Ok(coupon);
        }
    }
}
