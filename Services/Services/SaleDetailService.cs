using AutoMapper;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public async Task<List<SaleDetailDto>> GetAllSaleDetail(int saleId)
        {
            try
            {
                var saleEntity = await _uow.GetRepository<SaleDetail>().GetAll(x => x.SaleId == saleId);
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

        public async Task<List<SaleDetailDto>> GetAllSale(int id)
        {
            try
            {
                var list = await _uow.GetRepository<SaleDetail>().GetAll(x => x.SaleId == id, x => x.OrderBy(x => x.DateTime), x => x.Products);
                return _mapper.Map<List<SaleDetailDto>>(list);
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<SaleDetailDto> GetSaleDetailById(int saleDetailId)
        {
            try
            {
                var saleDetail = await _uow.GetRepository<SaleDetail>().GetById(saleDetailId);
                return _mapper.Map<SaleDetailDto>(saleDetail);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}