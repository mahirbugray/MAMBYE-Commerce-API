using AutoMapper;
using DataAccess.Identity.Model;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUnitOfWork _uow;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUnitOfWork uow, IUserService userService, IAuthService authService, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _uow = uow;
            _userService = userService;
            _authService = authService;
            _mapper = mapper;
        }
        public async Task<UserDto> Login(LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null) 
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    UserDto userDto = await _userService.GetByIdUser(user.Id);
                    userDto.AccessToken = _authService.GenerateToken(user.Id.ToString());
                    return userDto;
                }
            }
            return null;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<string> RegisterAsync(RegisterDto model)  //Kayıt olma
        {
            string msg = string.Empty;

            var appUser = _mapper.Map<AppUser>(model);

            var identity = await _userManager.CreateAsync(appUser, model.ConfirmPassword);

            if (identity.Succeeded)
            {
                msg = "OK";
            }
            else
            {

            }
            return msg;
        }

        public async Task<string> ResetPasswordControl(string username)
        {
            string msg = string.Empty;
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                string token = await _userManager.GeneratePasswordResetTokenAsync(user);
                return token;
            }
            msg = "Not Found";
            return msg;
        }

        public async Task<string> ResetPassword(PasswordResetDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
                if (result.Succeeded)
                {
                    return "OK";
                }
                else
                {
                    return result.Errors.ToString();
                }

            }
            return string.Empty;
        }

        //public async Task<PasswordResetDto> FindUser(PasswordResetDto model) //model üzerinden email ve kullanıcıadı çekiliyor.
        //{
        //    PasswordResetDto passwordReset = new PasswordResetDto();
        //    if (model.Email != null && model.Username != null)
        //    {
        //        var user = await _userManager.FindByEmailAsync(model.Email);
        //        if (user != null && user.UserName == model.Username)
        //        {
        //            passwordReset.Token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //            passwordReset.Id = user.Id;
        //            return passwordReset;
        //        }
        //    }
        //    return passwordReset;
        //}
    }
}
