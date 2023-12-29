using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ISaleService
    {
        Task<List<SaleDto>> GetAll();
        Task<SaleDto> GetByUserId(int userId);
        Task<SaleDto> GetById(int id);
        Task<string> Create(PaymentPostDto model, int userId);
        Task<string> Delete(int id);
    }
}
