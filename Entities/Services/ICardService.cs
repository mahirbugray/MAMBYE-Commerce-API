using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICardService
    {
        Task<int> CreateCart(CardDto cardDto);
        Task<string> DeleteCart(int cardId);
        Task<string> UpdateCart(CardDto cardDto);
        Task<List<CardDto>> GetAllCard();
        Task<List<CardLineDto>> GetCardLines();

    }
}
