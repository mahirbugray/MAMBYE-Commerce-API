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

        public async Task<UpdateUserDto> UpdateProfileInformation(UpdateUserDto model)
        {
            try
            {
                var user = await _uow.GetRepository<AppUser>().Get(x => x.Email == model.Email);
                user.Address = model.Address ?? user.Address;
                user.PhoneNumber = model.PhoneNumber ?? null;
                user.Email = model.Email ?? user.Email;
                user.BirthDate = model.BirthDate != null ? model.BirthDate : user.BirthDate;
                user.Name = model.Name ?? user.Name;
                user.Surname = model.Surname ?? user.Surname;
                user.UserName = model.UserName ?? user.UserName;
                _uow.GetRepository<AppUser>().Update(user);
                _uow.Commit();
                return _mapper.Map<UpdateUserDto>(user);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
