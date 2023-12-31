﻿using AutoMapper;
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
        public async Task<List<SaleDto>> GetAll()
        {
            var sales = await _unitOfWork.GetRepository<Sale>().GetAllAsync();
            return _mapper.Map<List<SaleDto>>(sales);
        }

        public async Task<SaleDto> GetById(int id)
        {
            var sale = await _unitOfWork.GetRepository<Sale>().GetById(id);
            return _mapper.Map<SaleDto>(sale);
        }
        public async Task<string> Create(PaymentPostDto model, int userId)
        {

            try
            {
                Sale newSale = new Sale()
                {
                    AptNumber = model.aptNo,
                    TotalPrice = model.totalPrice,
                    City = model.city,
                    Neighbourhood = model.neighbourhood,
                    ZipCode = model.postCode,
                    CardOwner = model.cardName,
                    CardNumber = model.cardNo,
                    UserId = userId,
                    TotalQuantity = model.cardLines.Sum(x => x.Quantity)
                };
                await _unitOfWork.GetRepository<Sale>().Add(newSale);
                await _unitOfWork.CommitAsync();

                foreach (var item in model.cardLines)
                {
                    SaleDetail detail = new SaleDetail()
                    {
                        SaleId = newSale.Id,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    };
                    await _unitOfWork.GetRepository<SaleDetail>().Add(detail);
                    await _unitOfWork.CommitAsync();
                }
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

        public async Task<List<SaleDto>> GetByUserId(int userId)
        {
            // Kullanıcının siparişlerini al
            var sales = await _unitOfWork.GetRepository<Sale>().GetAll(s => s.UserId == userId);

            // Sale nesnesini SaleDto'ya dönüştür
            var saleDtos = _mapper.Map<List<SaleDto>>(sales);

            // Her bir sipariş için detayları doldur
            foreach (var saleDto in saleDtos)
            {
                var saleDetails = await _unitOfWork.GetRepository<SaleDetail>().GetAll(d => d.SaleId == saleDto.Id);
                saleDto.SaleDetails = _mapper.Map<List<SaleDetailDto>>(saleDetails);
            }

            return saleDtos;
        }
    }
}
