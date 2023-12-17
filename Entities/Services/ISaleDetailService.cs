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
        Task<List<SaleDetailDto>> GetAllSaleDetail(int saleId);
        Task<SaleDetailDto> GetSaleDetailById(int saleDetailId);
        Task<string> CreateSaleDetail(SaleDetailDto model);
    }
}