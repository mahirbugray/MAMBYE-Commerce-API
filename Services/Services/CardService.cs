using AutoMapper;
using DataAccess.UnitOfWork;
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
    public class CardService : ICardService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper mapper;

        public CardService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            this.mapper = mapper;
        }

        public async Task<int> CreateCart(CardDto cardDto)
        {
            try
            {
                Card model = new Card()
                {
                    UserId = cardDto.Id,
                    TotalPrice = cardDto.TotalPrice,
                    IsDeleted = false,
                    DateTime = DateTime.Now,
                };
                await _uow.GetRepository<Card>().Add(model);
                await _uow.CommitAsync();
                return model.Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public Task DeleteCart(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CardDto>> GetAllCard()
        {
            throw new NotImplementedException();
        }

        public Task<List<CardLineDto>> GetCardLines()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCart(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
