using DataAccess.Identity.Model;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class MambyContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public MambyContext(DbContextOptions options) : base(options) 
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Command> Commands  { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SalesDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product { Id = 1, Name = "Air-Force", Description = "Erkek Ayakkabısı", Brand = "NIKE", Stock = 50, Price = 2500, ThumbnailImage = "/images/images.jpeg", ContentImage = "/images/content1.webp", ContentImage2 = "/images/content2.webp", ContentImage3 = "/images/content3.webp", ContentImage4 = "/images/thumbnail.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 2, Name = "Erkek Takım Elbise", Description = "Slim Fit Siyah Düz Takim Elbise", Brand = "DS Damat", Stock = 120, Price = 9999, ThumbnailImage = "/images/takımthubnail.webp", ContentImage = "/images/takımcontent1.webp", ContentImage2 = "/images/takımcontent2.webp", ContentImage3 = "/images/takımcontent3.webp", ContentImage4 = "/images/takımcontent4.webp", Point = 10, CategoryId = 2, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 3, Name = "Oyuncu Bilgisayarı", Description = "Asus ROG Strix G18 G814JI-N6079 Intel Core i9 13980HX 16GB 1TB SSD RTX4070 Freedos 18 WQXGA 240Hz Taşınabilir Bilgisayar", Brand = "Asus ROG", Stock = 78, Price = 74956, ThumbnailImage = "/images/asusthumbnail.jpeg", ContentImage = "/images/asuscontent1.jpeg", ContentImage2 = "/images/asuscontent2.jpeg", ContentImage3 = "/images/asuscontent3.jpeg", ContentImage4 = "/images/asuscontent4.jpeg", Point = 10, CategoryId = 4, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 4, Name = "Galatasaray 23-24 Sezonu İç Saha Forma", Description = "Nike Galatasaray 2023/2024 Parçalı İç Saha Forma FN0200-836", Brand = "Nike", Stock = 500, Price = 1200, ThumbnailImage = "/images/gsthumbnail.webp", ContentImage = "/images/gscontent1.webp", ContentImage2 = "/images/gscontent2.webp", ContentImage3 = "/images/gscontent3.webp", ContentImage4 = "/images/gscontent4.webp", Point = 10, CategoryId = 5, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 5, Name = "Erkek Parfüm", Description = "Giorgio Armani, güçlü ve şehvetli bir iz için aromatik ve odunsu notalara sahip erkekler için yeni doldurulabilir parfümü ARMANI CODE PARFUM'u tanıttı.", Brand = "Armani", Stock = 300, Price = 5990, ThumbnailImage = "/images/armanithumbnail.webp", ContentImage = "/images/armanicontent1.webp", ContentImage2 = "/images/armanicontent2.webp", ContentImage3 = "/images/armanicontent3.webp", ContentImage4 = "/images/armanicontent4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, CategoryName = "Giyim", Description = "Erkek - Kadın - Çocuk kıyafet.", DateTime = DateTime.Now, IsDeleted = false },
                new Category { Id = 4, CategoryName = "Elektronik", Description = "Teknolojik araçlar.", DateTime = DateTime.Now, IsDeleted = false },
                new Category { Id = 5, CategoryName = "Spor & Outdoor", Description = "Spor ve dış giyim malzemeleri.", DateTime = DateTime.Now, IsDeleted = false },
                new Category { Id = 7, CategoryName = "Ayakkabı", Description = "Erkek - Kadın - Çocuk ayakkabı.", DateTime = DateTime.Now, IsDeleted = false },
                new Category { Id = 9, CategoryName = "Kozmetik", Description = "Makyaj ve kişisel bakım malzemeleri.", DateTime = DateTime.Now, IsDeleted = false },
                new Category { Id = 11, CategoryName = "Ev & Yaşam", Description = "Ev ve yaşam için gerekli genel malzemeler.", DateTime = DateTime.Now, IsDeleted = false }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
