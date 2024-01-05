using Entity.DTOs;
using Entity.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IProductFeatureService
    {
        Task<string> Add(List<ProductFeatureDto> featureDto);
        Task<List<ProductFeatureDto>> GetAllProductFeature(int productId); 
    }
}
