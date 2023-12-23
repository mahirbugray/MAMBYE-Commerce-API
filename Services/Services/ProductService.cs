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
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork _uow;
		private readonly IMapper _mapper;

		public ProductService(IUnitOfWork uow, IMapper mapper)
		{
			_uow = uow;
			_mapper = mapper;
		}

		public async Task<string> AddProduct(ProductDto productDto)
		{
			try
			{
				var productEntity = _mapper.Map<ProductDto>(productDto);
				await _uow.GetRepository<ProductDto>().Add(productEntity);
				_uow.Commit();

				return "OK";

			}
			catch (Exception ex)
			{

				return ex.Message;
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
				var product = await _uow.GetRepository<Product>().Get(x => x.Id == productId, null, x => x.Category);
				product.Category.Products = null;
				return _mapper.Map<ProductDto>(product);

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
