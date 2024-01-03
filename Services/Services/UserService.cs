using AutoMapper;
using DataAccess.Identity.Model;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<AppUser> _userManager;

        public UserService(IMapper mapper, IUnitOfWork uow, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _uow = uow;
            _userManager = userManager;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            try
            {
                var list = await _userManager.Users.ToListAsync();
                return _mapper.Map<List<UserDto>>(list);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<UserDto> GetByIdUser(int id)
        {
            try
            {
                var user = await _uow.GetRepository<AppUser>().Get(x => x.Id == id);
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception)
            {
                return null;
            }
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
