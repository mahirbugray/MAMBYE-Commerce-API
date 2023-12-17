using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity.Services
{
    public interface ISaleDetailService
    {
        Task<IEnumerable<SaleDetailDto>> GetAllSaleDetail(int saleDetailId);
        Task<SaleDetailDto> GetSaleDetailById(int saleDetailId);
        Task<string> CreateSaleDetail(SaleDetailDto model);
    }
}