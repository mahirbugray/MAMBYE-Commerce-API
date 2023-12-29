﻿using Entity.DTOs;
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
        Task<SaleDto> GetById(int id);
        Task<string> Create(PaymentPostDto model);
        Task<string> Delete(int id);
    }
}
