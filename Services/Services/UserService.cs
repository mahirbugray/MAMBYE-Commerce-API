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
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UserService(IMapper mapper, IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<UserDto> GetByIdUser(int id)
        {
            var user = await _uow.GetRepository<AppUser>().Get(x => x.Id == id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<string> UpdateProfileInformation(UpdateUserDto model)
        {
            try
            {
                var user = await _uow.GetRepository<AppUser>().Get(x => x.Email == model.Email);
               _mapper.Map<UpdateUserDto>(user);
                return "OK";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
