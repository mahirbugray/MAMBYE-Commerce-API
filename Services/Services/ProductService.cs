using AutoMapper;
using DataAccess.Identity.Model;
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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<int> AddProduct(ProductDto productDto)
        {
            try
            {
                var productEntity = _mapper.Map<Product>(productDto);
                await _uow.GetRepository<Product>().Add(productEntity);
                _uow.Commit();

                return productEntity.Id;

            }
            catch (Exception)
            {

                return 0;
            }
        }

        public string DeleteProduct(int productId)
        {
            try
            {
                _uow.GetRepository<Product>().DeleteById(productId);
                _uow.Commit();

                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<ProductDto>> GetAllWithCategory()
        {
            try
            {
                var products = await _uow.GetRepository<Product>().GetAll(null, null, x => x.Category);
                List<Product> products1 = products.Select(x => new Product
                {
                    Brand = x.Brand,
                    Name = x.Name,
                    Commands = x.Commands,
                    ContentImage = x.ContentImage,
                    ContentImage2 = x.ContentImage2,
                    ContentImage3 = x.ContentImage3,
                    ContentImage4 = x.ContentImage4,
                    DateTime = x.DateTime,
                    Description = x.Description,
                    Id = x.Id,
                    IsDeleted = x.IsDeleted,
                    Point = x.Point,
                    Price = x.Price,
                    Stock = x.Stock,
                    ThumbnailImage = x.ThumbnailImage,
                    CategoryId = x.CategoryId,
                    Category = new Category
                    {
                        Id = x.Category.Id,
                        Description = x.Category.Description,
                        CategoryName = x.Category.CategoryName,
                        DateTime = x.Category.DateTime,
                        IsDeleted = x.Category.IsDeleted
                    }
                }).ToList();
                return _mapper.Map<List<ProductDto>>(products1);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            try
            {
                var products = await _uow.GetRepository<Product>().GetAllAsync();
                return _mapper.Map<List<ProductDto>>(products);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<int> GetCountByCategory(int id)
        {
            try
            {
                var list = await _uow.GetRepository<Product>().GetAll(x => x.CategoryId == id, null, x => x.Category);
                return list.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public Task<List<ProductDto>> GetListAFilter()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByFilter()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            try 
            {
                var product = await _uow.GetRepository<Product>().Get(x => x.Id == productId, null, x => x.Category, x => x.Commands, x=> x.ProductFeatures);
                var mappedList = _mapper.Map<ProductDto>(product);
                if (mappedList.Commands.Count() > 0)
                {
                    foreach (var item in mappedList.Commands)
                    {
                        var user = await _uow.GetRepository<AppUser>().Get(x => x.Id == item.UserId);
                        item.User = _mapper.Map<UserDto>(user);
                    }
                }

                return mappedList;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public ProductDto GetProductByIdNoAsync(int productId)
        {
            try
            {
                var product = _uow.GetRepository<Product>().GetByIdNoAsync(productId);
                return _mapper.Map<ProductDto>(product);

            }
            catch (Exception)
            {
                ProductDto product = new ProductDto();
                return product;
            }
        }

        public async Task<List<ProductDto>> GetProductBySearch(string search)
        {
            try
            {
                var list = await _uow.GetRepository<Product>().GetAll(x => x.Name.ToLower().Contains(search.ToLower()) && x.IsDeleted == false);
                return _mapper.Map<List<ProductDto>>(list.Where(x => x.IsDeleted == false));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            try
            {
                var products = await _uow.GetRepository<Product>().GetAll(x => x.CategoryId == categoryId, null, x => x.Category);
                return _mapper.Map<List<ProductDto>>(products);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            try
            {
                var productOld = await _uow.GetRepository<Product>().Get(x => x.Id == productDto.Id);
                productOld.Name = productDto.Name ?? productOld.Name;
                productOld.Description = productDto.Description ?? productOld.Description;
                productOld.Brand = productDto.Brand ?? productOld.Brand;
                productOld.Stock = productDto.Stock != null ? (int)productDto.Stock : 10;
                productOld.Point = productDto.Point != null ? (int)productDto.Point : 0;
                productOld.ThumbnailImage = productDto.ThumbnailImage ?? productOld.ThumbnailImage;
                productOld.ContentImage = productDto.ContentImage ?? productOld.ContentImage;
                productOld.ContentImage2 = productDto.ContentImage2 ?? productOld.ContentImage2;
                productOld.ContentImage3 = productDto.ContentImage3 ?? productOld.ContentImage3;
                productOld.ContentImage4 = productDto.ContentImage4 ?? productOld.ContentImage4;
                _uow.GetRepository<Product>().Update(productOld);
                _uow.Commit();
                return productDto;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
