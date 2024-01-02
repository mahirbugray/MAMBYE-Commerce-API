using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IProductService
    {
        Task<string> AddProduct(ProductDto productDto);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        string DeleteProduct(int productId);
        Task<ProductDto> GetProductById(int productId);
        ProductDto GetProductByIdNoAsync(int productId);
        Task<List<ProductDto>> GetListAFilter();
        Task<ProductDto> GetProductByFilter();
        Task<List<ProductDto>> GetAllProducts();
        Task<List<ProductDto>> GetProductsByCategory(int categoryId);
        Task<List<ProductDto>> GetProductBySearch(string search);
        Task<int> GetCountByCategory(int id);
        Task<List<ProductDto>> GetAllWithCategory();
    }
}
