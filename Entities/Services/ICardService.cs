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
        Task DeleteCart(int productId);
        Task UpdateCart(int productId, int quantity);
        Task<List<CardDto>> GetAllCard();
        Task<List<CardLineDto>> GetCardLines();

    }
}
