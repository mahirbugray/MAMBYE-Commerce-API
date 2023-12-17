using AutoMapper;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CouponService : ICouponService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CouponService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CouponDto>> GetAllCoupons()
        {
            var coupons = await _uow.GetRepository<Coupon>().GetAllAsync();
            return _mapper.Map<IEnumerable<CouponDto>>(coupons);
        }

        public async Task<CouponDto> GetCouponById(int id)
        {
            var coupon = await _uow.GetRepository<Coupon>().GetById(id);
            return _mapper.Map<CouponDto>(coupon);
        }
        public async Task<string> CreateCoupon(CouponDto couponDto)
        {
            try
            {
                var couponEntity = _mapper.Map<Coupon>(couponDto);
                await _uow.GetRepository<Coupon>().Add(couponEntity);
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string UpdateCoupon(CouponDto couponDto)
        {
            var mapperCoupon = _mapper.Map<Coupon>(couponDto);
            _uow.GetRepository<Coupon>().Update(mapperCoupon);
            _uow.Commit();
            return "OK";
        }
    }
}
