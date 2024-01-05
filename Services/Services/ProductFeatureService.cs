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

        public ProductFeatureService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<string> Add(List<ProductFeatureDto> featureDto)
        {
            try
            {
                foreach (var feature in featureDto)
                {
                    await _uow.GetRepository<ProductFeature>().Add(_mapper.Map<ProductFeature>(feature));
                }
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<ProductFeatureDto>> GetAllProductFeature(int categoryId)
        {
            try
            {
                var list = await _uow.GetRepository<ProductFeature>().GetAll(x => x.Products.CategoryId == categoryId, null, x => x.Products);
                list.Where(x => x.ProductId == list.Min(x => x.ProductId));
                return _mapper.Map<List<ProductFeatureDto>>(list);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
