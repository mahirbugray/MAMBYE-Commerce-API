using AutoMapper;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductFeatureService : IProductFeatureService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public async Task<string> Add(ProductFeatureDto featureDto)
        {
            try
            {
                await _uow.GetRepository<ProductFeature>().Add(_mapper.Map<ProductFeature>(featureDto));
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<ProductFeatureDto>> GetAll(int productId)
        {
            try
            {
                var list = await _uow.GetRepository<ProductFeature>().GetAll(x => x.ProductId == productId, null, x => x.Product);
                list = list.Where(x => x.ProductId == list.Min(x => x.ProductId)).ToList();
                return _mapper.Map<List<ProductFeatureDto>>(list);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
