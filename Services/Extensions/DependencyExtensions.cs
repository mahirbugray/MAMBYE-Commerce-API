using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using DataAccess.Identity.Model;
using Microsoft.AspNetCore.Identity;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Http;
using Entity.Services;
using Services.Services;
using Entity.IUnitOfWork;
using DataAccess.UnitOfWork;
using Entity.Repositories;
using DataAccess.Repositories;
using Services.Mapping;

namespace Services.Extensions
{
    public static class DependencyExtensions
    {
        public static void AddExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtDefaults = configuration.GetSection("JwtDefaults");
            var secretKey = jwtDefaults["secretKey"];
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,   //token üret
                    ValidateAudience = true,  //token denetle
                    ValidateLifetime = true,   //token ömür kontrolleri
                    ValidateIssuerSigningKey = true, //bizim verdiğimiz secret keyi kullan

                    ValidIssuer = jwtDefaults["ValidIssur"], //appsetting deki değeri alır
                    ValidAudience = jwtDefaults["ValidAudience"], //appsettingden değeri alır
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)), //bizim verdiğimiz keyi encode eder
                    //ClockSkew = TimeSpan.Zero //isteyen cihazla aradaki saat farkını sıfırlar
                };
            });

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;  //karakter istemesin
                options.Password.RequiredLength = 3;  //uzunluğu en az 3 karakter olsun
                options.Password.RequireUppercase = false; //büyük harf istemesin
                options.Password.RequireLowercase = false;  //Küçük harf istemesin
                options.Password.RequireDigit = false; //sayı istemesin
                                                       //options.User.AllowedUserNameCharacters = "abcdefghijklmnoprstuvyzqw0123456789";  sadece bunlar kabul edilsin
                                                       //  options.User.RequireUniqueEmail = false; //e mail eşsisiz olmalı
                options.Lockout.MaxFailedAccessAttempts = 3;  //3 yanlış denemeden sonra girişi altaki süre kadar durdur
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);  // üstteki sayı kadaryanlış girişten sonra 1 dk girişi engeller

            }).AddEntityFrameworkStores<MambyContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            });

            services.ConfigureApplicationCookie(op =>
            {

                op.ExpireTimeSpan = TimeSpan.FromMinutes(100); //cookie ömrü dk
                                                               //op.AccessDeniedPath = new PathString("yetisi yok sayfası"); // yetkisi olmayinca yönlendirme
                op.SlidingExpiration = true; //üsstteki 10 dk dolmadan tekar login olursa tekrar süreyi başa alır
                op.Cookie = new CookieBuilder()
                {
                    Name = "MammbyECOmmerceCookie", //cookie adı
                    HttpOnly = false,  //sadece tarayıcıdan girilsin programlar yakalayamayacak

                };

            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
