using AutoMapper;
using DataAccess.Identity.Model;
using Entity.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, AppUser>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CouponDto, Coupon>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProductFeatureDto, ProductFeature>().ReverseMap();
            CreateMap<SaleDto, Sale>().ReverseMap();
            CreateMap<SaleDetailDto, SaleDetail>().ReverseMap();
            CreateMap<CommandDto, Command>().ReverseMap();
            CreateMap<RegisterDto, AppUser>().ReverseMap();
            CreateMap<UpdateUserDto, AppUser>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<RoleDto, AppRole>().ReverseMap();
        }
    }
}
