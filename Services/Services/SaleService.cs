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
    public class SaleService : ISaleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SaleService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<SaleDto>> GetAll()
        {
            var sales = await _unitOfWork.GetRepository<Sale>().GetAllAsync();
            return _mapper.Map<IEnumerable<SaleDto>>(sales);
        }

        public async Task<SaleDto> GetById(int id)
        {
            var sale = await _unitOfWork.GetRepository<Sale>().GetById(id);
            return _mapper.Map<SaleDto>(sale);
        }
        public async Task<string> Create(SaleDto model)
        {
            try
            {
                var saleEntity = _mapper.Map<Sale>(model);
                await _unitOfWork.GetRepository<Sale>().Add(saleEntity);
                await _unitOfWork.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Delete(int id)
        {
            try
            {
                _unitOfWork.GetRepository<Sale>().DeleteById(id);
                _unitOfWork.Commit();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
