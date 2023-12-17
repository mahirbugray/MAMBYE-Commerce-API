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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<string> CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                var mapperCategory = _mapper.Map<Category>(categoryDto);
                await _uow.GetRepository<Category>().Add(mapperCategory);
                _uow.Commit();
                return "Ok";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteCategory(int id)
        {
            try
            {
                _uow.GetRepository<Category>().DeleteById(id);
                _uow.Commit();
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async Task<List<CategoryDto>> GetAllCategory()
        {
            var list = await _uow.GetRepository<Category>().GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(list);
        }

        public async Task<CategoryDto> UpdateCategory(CategoryDto categoryDto)
        {
            try
            {
                var categoryOld = await _uow.GetRepository<Category>().Get(x => x.Id == categoryDto.Id);
                categoryOld.CategoryName = categoryDto.CategoryName?? categoryOld.CategoryName;                             //? if anlamına gelir    ?? null ise şunu kullan anlamında kullanılır.
                categoryOld.Description = categoryDto.Description?? categoryOld.Description;
                categoryOld.DateTime = DateTime.Now;
                _uow.GetRepository<Category>().Update(categoryOld);
                _uow.Commit();
                return categoryDto;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }
    }
}
