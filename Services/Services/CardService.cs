using AutoMapper;
using DataAccess.UnitOfWork;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using Microsoft.AspNetCore.Http.HttpResults;
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
        private readonly IMapper _mapper;

        public CardService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
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
        public async Task<string> DeleteCart(int cardId)
        {
            try
            {
                var card = await _uow.GetRepository<Card>().GetById(cardId);

                if (card != null)
                {
                    _uow.GetRepository<Card>().Delete(card);
                    await _uow.CommitAsync();
                    return "Ok";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }
        public async Task<string> UpdateCart(CardDto cardDto)
        {
            try
            {
                var card = await _uow.GetRepository<Card>().GetById(cardDto.Id);

                if (card != null)
                {
                    card.TotalPrice = cardDto.TotalPrice;


                    _uow.GetRepository<Card>().Update(card);
                    await _uow.CommitAsync();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }

        public async Task<List<CardDto>> GetAllCard()
        {
            try
            {
                var cards = await _uow.GetRepository<Card>().GetAllAsync();
                return _mapper.Map<List<CardDto>>(cards);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<List<CardLineDto>> GetCardLines()
        {
            try
            {
                var cardLines = await _uow.GetRepository<CardLine>().GetAllAsync();
                return _mapper.Map<List<CardLineDto>>(cardLines);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

