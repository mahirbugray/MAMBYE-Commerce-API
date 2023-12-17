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
    public class SaleDetailService : ISaleDetailService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public SaleDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SaleDetailDto>> GetAllSaleDetail(int saleDetailId)
        {
            try
            {
                var saleEntity = await _uow.GetRepository<SaleDetail>().GetAll(x => x.SaleId == saleDetailId);
                if (saleEntity == null)
                {
                    return null;
                }
                return _mapper.Map<List<SaleDetailDto>>(saleEntity);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> CreateSaleDetail(SaleDetailDto model)
        {
            try
            {
                var saleEntity = _mapper.Map<SaleDetail>(model);
                await _uow.GetRepository<SaleDetail>().Add(saleEntity);
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public Task<SaleDetailDto> GetSaleDetailById(int saleDetailId)
        {
            throw new NotImplementedException();
        }
    }
}