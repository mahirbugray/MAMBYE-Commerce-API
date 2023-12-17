using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICategoryService
    {
        Task<string> CreateCategory(CategoryDto categoryDto);
        Task<CategoryDto> UpdateCategory(CategoryDto categoryDto);
        string DeleteCategory(int id);
        Task<List<CategoryDto>> GetAllCategory();
    }
}
