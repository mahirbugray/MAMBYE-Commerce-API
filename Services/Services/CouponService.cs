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

        public async Task<List<CouponDto>> GetAllCoupons()
        {
            var coupons = await _uow.GetRepository<Coupon>().GetAllAsync();
            return _mapper.Map<List<CouponDto>>(coupons);
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

        public async Task<string> UpdateCoupon(CouponDto couponDto)
        {
            try
            {
                var couponOld = await _uow.GetRepository<Coupon>().Get(x => x.Id == couponDto.Id);
                couponOld.Discount = couponDto.Discount;
                couponOld.Description = couponDto.Description ?? couponOld.Description;
                couponOld.GivenDate = DateTime.Now;
                _uow.GetRepository<Coupon>().Update(couponOld);
                _uow.Commit();
                return "OK";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
