using AutoMapper;
using DataAccess.Identity.Model;
using Entity.DTOs;
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
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleService(IMapper mapper, IUnitOfWork uow, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _uow = uow;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<string> EditRoleListAsync(EditRoleDto model)
        {
            try
            {
                string message = "OK";
                foreach (var userId in model.UserIdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (result.Succeeded)
                        {
                            message = $"{user.UserName} role eklenemedi.";
                        }
                    }

                }
                foreach (var userId in model.UserIdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            message = $"{user.UserName} rolden çıkarılamadı.";
                        }
                    }
                }
                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<RoleDto> FindRoleByIdAsync(string id)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(id);
                return _mapper.Map<RoleDto>(role);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<RoleDto>> GetAllRoles()
        {
            try
            {
                var roles = await _roleManager.Roles.ToListAsync();
                return _mapper.Map<List<RoleDto>>(roles);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<UsersInOrOutDto> GetAllUsersWithRole(string id)
        {
            try
            {
                var role = await this.FindRoleByIdAsync(id);

                var usersInRole = new List<AppUser>();
                var usersOutRole = new List<AppUser>();

                var users = await _userManager.Users.ToListAsync();

                foreach (var user in users)
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        usersInRole.Add(user);  //Bu rolde bulunan kullanıcıların listesi
                    }
                    else
                    {
                        usersOutRole.Add(user); //Bu rolde olmayan kullanıcıların listesi
                    }
                }
                UsersInOrOutDto model = new UsersInOrOutDto()
                {
                    Role = _mapper.Map<RoleDto>(role),
                    UsersInRole = _mapper.Map<List<UserDto>>(usersInRole),
                    UsersOutRole = _mapper.Map<List<UserDto>>(usersOutRole)
                };
                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
