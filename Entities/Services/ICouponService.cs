using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICouponService
    {
        Task<List<CouponDto>> GetAllCoupons();
        Task<CouponDto> GetCouponById(int id);
        Task<string> CreateCoupon(CouponDto couponDto);
        Task<string> UpdateCoupon(CouponDto couponDto);
    }
}
