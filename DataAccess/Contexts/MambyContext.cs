using DataAccess.Identity.Model;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public DbSet<Command> Commands { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SalesDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                //-------AYAKKABILAR---------
                new Product { Id = 1, Name = "Air-Force Ayakkabı", Description = "Rahatlık ve moda odaklı tasarlanmış şık erkek ayakkabısı. Bu NIKE Air-Force ayakkabıları, günlük veya spor giyim için mükemmel bir seçenek sunar.", Brand = "NIKE", Stock = 50, Price = 2500, ThumbnailImage = "/images/thumbnail.webp", ContentImage = "/images/content2.webp", ContentImage2 = "/images/content3.webp", ContentImage3 = "/images/content0.webp", ContentImage4 = "/images/content1.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 2, Name = "Nike-Cortez Ayakkabı", Description = "Stil ve işlevselliğe odaklanan NIKE tarafından tasarlanmış şık kadın ayakkabıları. Nike-Cortez koleksiyonu, günlük giyim için moda ve konforu mükemmel bir şekilde birleştiriyor.", Brand = "NIKE", Stock = 50, Price = 3499, ThumbnailImage = "/images/NikeCortez.webp", ContentImage = "/images/NikeCortez1.webp", ContentImage2 = "/images/NikeCortez2.webp", ContentImage3 = "/images/NikeCortez3.webp", ContentImage4 = "/images/NikeCortez4.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 3, Name = "Nike V2 Run Ayakkabı", Description = "NIKE, aktif bir yaşam tarzı için tasarlanmış kadın ayakkabısı olan V2 Run'u sunar. Bu rahat ve dayanıklı koşu ayakkabıları ile performans ve stilin tadını çıkarın.", Brand = "NIKE", Stock = 50, Price = 2999, ThumbnailImage = "/images/NikeV2KRun.webp", ContentImage = "/images/NikeCortez2.webp", ContentImage2 = "/images/NikeV2KRun3.webp", ContentImage3 = "/images/NikeV2KRun4.webp", ContentImage4 = "/images/NikeV2KRun1.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 4, Name = "Nike AirMax 90 Futura Ayakkabı", Description = " Moda ve sporu bir araya getiren, kadınlar için ideal olan Nike AirMax 90 Futura. Bu ayakkabılar şık tasarımı ve gün boyu konforu ile öne çıkıyor.", Brand = "NIKE", Stock = 110, Price = 1499, ThumbnailImage = "/images/NikeAirMax90Futura1.webp", ContentImage = "/images/NikeAirMax90Futura2.webp", ContentImage2 = "/images/NikeAirMax90Futura3.webp", ContentImage3 = "/images/NikeAirMax90Futura4.webp", ContentImage4 = "/images/NikeAirMax90Futura5.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 5, Name = "Nike Court Vısıon Lo Ayakkabı", Description = "Stilin bir dokunuşuyla erkek spor ayakkabıları. Nike Court Vısıon Lo koleksiyonu, spor ve günlük kullanım için performans ile trend tasarımı mükemmel bir şekilde birleştiriyor.", Brand = "NIKE", Stock = 150, Price = 4999, ThumbnailImage = "/images/NikeCourtVısıonLo1.jpg", ContentImage = "/images/NikeCourtVısıonLo2.jpg", ContentImage2 = "/images/NikeCourtVısıonLo3.jpg", ContentImage3 = "/images/NikeCourtVısıonLo4.jpg", ContentImage4 = "/images/NikeCourtVısıonLo5.jpg", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 6, Name = "adidas Stan Smith Ayakkabı", Description = "Klasik erkek ayakkabılarından olan adidas Stan Smith koleksiyonu, zamansız stili ve konforuyla bilinir. Bu ikonik sneaker'lar ile günlük görünümünüzü yükseltin.", Brand = "adidas", Stock = 150, Price = 1849, ThumbnailImage = "/images/stansmith.webp", ContentImage = "/images/stansmith1.webp", ContentImage2 = "/images/stansmith2.webp", ContentImage3 = "/images/stansmith3.webp", ContentImage4 = "/images/stansmith4.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 7, Name = "adidas niteball unisex Ayakkabı", Description = "adidas'ın tasarladığı cinsiyet ayrımı olmayan spor ayakkabıları, Niteball koleksiyonu, çok yönlülük ve performans için tasarlanmıştır. Bu ayakkabılar çeşitli spor ve aktiviteler için uygundur.", Brand = "adidas", Stock = 150, Price = 1849, ThumbnailImage = "/images/adidasniteball.webp", ContentImage = "/images/adidasniteball1.webp", ContentImage2 = "/images/adidasniteball2.webp", ContentImage3 = "/images/adidasniteball3.webp", ContentImage4 = "/images/adidasniteball4.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 8, Name = "NewBalance530 Ayakkabı", Description = "NewBalance530 erkek ayakkabıları ile stil sahibi bir şekilde doğayı keşfedin. Bu NewBalance sneaker'lar, sert dayanıklılık ve modern tasarımın mükemmel bir kombinasyonunu sunar, aktif yaşam tarzınız için.", Brand = "NewBalance", Stock = 45, Price = 3599, ThumbnailImage = "/images/NewBalance530.webp", ContentImage = "/images/NewBalance5301.webp", ContentImage2 = "/images/NewBalance5302.webp", ContentImage3 = "/images/NewBalance5305.webp", ContentImage4 = "/images/NewBalance5304.webp", Point = 10, CategoryId = 7, DateTime = DateTime.Now, IsDeleted = false },
                //-------KOZMETİK---------
                new Product { Id = 9, Name = "Yves Saint Laurent Libre Eau De Parfum 30 ml", Description = "", Brand = "Yves Saint Laurent", Stock = 50, Price = 4099, ThumbnailImage = "/images/YSLLEauDeParfum.webp", ContentImage = "/images/YSLLEauDeParfum1.webp", ContentImage2 = "/images/YSLLEauDeParfum2.webp", ContentImage3 = "/images/YSLLEauDeParfum3.webp", ContentImage4 = "/images/YSLLEauDeParfum4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 10, Name = "Yves Saint Laurent L'Homme Le Parfum Edp 100 ml", Description = "", Brand = "Yves Saint Laurent", Stock = 50, Price = 3399, ThumbnailImage = "/images/YSLLHomme.webp", ContentImage = "/images/YSLLHomme1.webp", ContentImage2 = "/images/YSLLHomme2.webp", ContentImage3 = "/images/YSLLHomme3.webp", ContentImage4 = "/images/YSLLHomme4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 11, Name = "Erkek Parfüm", Description = "Giorgio Armani, güçlü ve şehvetli bir iz için aromatik ve odunsu notalara sahip erkekler için yeni doldurulabilir parfümü ARMANI CODE PARFUM'u tanıttı.", Brand = "Armani", Stock = 300, Price = 5990, ThumbnailImage = "/images/armanithumbnail.webp", ContentImage = "/images/armanicontent1.webp", ContentImage2 = "/images/armanicontent2.webp", ContentImage3 = "/images/armanicontent3.webp", ContentImage4 = "/images/armanicontent4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 12, Name = "Yves Saint Laurent Mon Paris Parfum Edp 30 ml", Description = "", Brand = "Yves Saint Laurent", Stock = 50, Price = 6049, ThumbnailImage = "/images/YSLMonParis.webp", ContentImage = "/images/YSLMonParis1.webp", ContentImage2 = "/images/YSLMonParis2.webp", ContentImage3 = "/images/YSLMonParis3.webp", ContentImage4 = "/images/YSLMonParis4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 13, Name = "Clinique Moisture Surge 100 Saat Etkili Nemlendirici 15 ml", Description = "", Brand = "Clinique", Stock = 50, Price = 350, ThumbnailImage = "/images/Clinique.webp", ContentImage = "/images/Clinique1.webp", ContentImage2 = "/images/Clinique2.webp", ContentImage3 = "/images/Clinique3.webp", ContentImage4 = "/images/Clinique4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 14, Name = "Mac Ruj / Lipstick - Velvet Teddy", Description = "", Brand = "M.A.C", Stock = 50, Price = 350, ThumbnailImage = "/images/MacRuj.webp", ContentImage = "/images/MacRuj1.webp", ContentImage2 = "/images/MacRuj2.webp", ContentImage3 = "/images/MacRuj3.webp", ContentImage4 = "/images/MacRuj4.webp", Point = 10, CategoryId = 9, DateTime = DateTime.Now, IsDeleted = false },
                //-------GİYİM---------
                new Product { Id = 15, Name = "Erkek Takım Elbise", Description = "Slim Fit Siyah Düz Takim Elbise", Brand = "DS Damat", Stock = 120, Price = 9999, ThumbnailImage = "/images/takımthubnail.webp", ContentImage = "/images/takımcontent1.webp", ContentImage2 = "/images/takımcontent2.webp", ContentImage3 = "/images/takımcontent3.webp", ContentImage4 = "/images/takımcontent4.webp", Point = 10, CategoryId = 2, DateTime = DateTime.Now, IsDeleted = false },
                //-------TEKNOLOJİ---------
                new Product { Id = 16, Name = "ASUS ProArt PA279CRV 27″ 5ms 60Hz Gaming Monitör", Description = "ProArt Display PA279CRV, profesyonel video editörleri için tasarlanan 27 inç 4K HDR bir monitördür. Calman Verified sertifikasına sahip ekran, %99 DCI-P3 geniş renk gamı, %99 Adobe RGB kapsaması ve olağanüstü renk doğruluğu için fabrikada kalibre edilen Delta E < 2 sunar. Ek kolaylıklar sağlamak için dahili USB-C® bağlantı noktası DisplayPort™, süper hızlı veri aktarımları ve tek kablo üzerinden 96-watt güç dağıtımı desteği sunar.", Brand = "Asus ROG", Stock = 78, Price = 24956, ThumbnailImage = "/images/ProArt.jpeg", ContentImage = "/images/ProArt1.jpeg", ContentImage2 = "/images/ProArt2.jpeg", ContentImage3 = "/images/ProArt3.jpeg", ContentImage4 = "/images/ProArt4.jpeg", Point = 10, CategoryId = 4, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 17, Name = "Oyuncu Bilgisayarı", Description = "Asus ROG Strix G18 G814JI-N6079 Intel Core i9 13980HX 16GB 1TB SSD RTX4070 Freedos 18 WQXGA 240Hz Taşınabilir Bilgisayar", Brand = "Asus ROG", Stock = 78, Price = 74956, ThumbnailImage = "/images/asusthumbnail.jpeg", ContentImage = "/images/asuscontent1.jpeg", ContentImage2 = "/images/asuscontent2.jpeg", ContentImage3 = "/images/asuscontent3.jpeg", ContentImage4 = "/images/asuscontent4.jpeg", Point = 10, CategoryId = 4, DateTime = DateTime.Now, IsDeleted = false },
                new Product { Id = 18, Name = "Asus GeForce RTX 4080 Noctua OC 16G GDDR6X 256Bit DX12 DLSS 3 Gaming (Oyuncu) Ekran Kartı", Description = "", Brand = "Asus ROG", Stock = 78, Price = 74956, ThumbnailImage = "/images/RTX4080.jpg", ContentImage = "/images/RTX40801.jpg", ContentImage2 = "/images/RTX40802.jpg", ContentImage3 = "/images/RTX40803.jpg", ContentImage4 = "/images/RTX40804.jpg", Point = 10, CategoryId = 4, DateTime = DateTime.Now, IsDeleted = false },
                //-------SPOR---------
                new Product { Id = 19, Name = "Galatasaray 23-24 Sezonu İç Saha Forma", Description = "Nike Galatasaray 2023/2024 Parçalı İç Saha Forma FN0200-836", Brand = "Nike", Stock = 500, Price = 1200, ThumbnailImage = "/images/gsthumbnail.webp", ContentImage = "/images/gscontent1.webp", ContentImage2 = "/images/gscontent2.webp", ContentImage3 = "/images/gscontent3.webp", ContentImage4 = "/images/gscontent4.webp", Point = 10, CategoryId = 5, DateTime = DateTime.Now, IsDeleted = false }

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