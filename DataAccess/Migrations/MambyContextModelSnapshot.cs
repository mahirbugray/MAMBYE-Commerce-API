﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MambyContext))]
    partial class MambyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Identity.Model.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("DataAccess.Identity.Model.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Entity.Entities.CardLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ProductId");

                    b.ToTable("CardLines");
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CategoryName = "Giyim",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(63),
                            Description = "Erkek - Kadın - Çocuk kıyafet.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Elektronik",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(65),
                            Description = "Teknolojik araçlar.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Spor & Outdoor",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(67),
                            Description = "Spor ve dış giyim malzemeleri.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Ayakkabı",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(69),
                            Description = "Erkek - Kadın - Çocuk ayakkabı.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Kozmetik",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(70),
                            Description = "Makyaj ve kişisel bakım malzemeleri.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 11,
                            CategoryName = "Ev & Yaşam",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 491, DateTimeKind.Local).AddTicks(72),
                            Description = "Ev ve yaşam için gerekli genel malzemeler.",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Entity.Entities.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("Entity.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTime>("GivenDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("Entity.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ContentImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentImage2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentImage3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentImage4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "NIKE",
                            CategoryId = 7,
                            ContentImage = "/images/content1.webp",
                            ContentImage2 = "/images/content2.webp",
                            ContentImage3 = "/images/content3.webp",
                            ContentImage4 = "/images/thumbnail.webp",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 490, DateTimeKind.Local).AddTicks(9750),
                            Description = "Erkek Ayakkabısı",
                            IsDeleted = false,
                            Name = "Air-Force",
                            Point = 10,
                            Price = 2500m,
                            Stock = 50,
                            ThumbnailImage = "/images/images.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "DS Damat",
                            CategoryId = 2,
                            ContentImage = "/images/takımcontent1.webp",
                            ContentImage2 = "/images/takımcontent2.webp",
                            ContentImage3 = "/images/takımcontent3.webp",
                            ContentImage4 = "/images/takımcontent4.webp",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 490, DateTimeKind.Local).AddTicks(9755),
                            Description = "Slim Fit Siyah Düz Takim Elbise",
                            IsDeleted = false,
                            Name = "Erkek Takım Elbise",
                            Point = 10,
                            Price = 9999m,
                            Stock = 120,
                            ThumbnailImage = "/images/takımthubnail.webp"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Asus ROG",
                            CategoryId = 4,
                            ContentImage = "/images/asuscontent1.jpeg",
                            ContentImage2 = "/images/asuscontent2.jpeg",
                            ContentImage3 = "/images/asuscontent3.jpeg",
                            ContentImage4 = "/images/asuscontent4.jpeg",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 490, DateTimeKind.Local).AddTicks(9761),
                            Description = "Asus ROG Strix G18 G814JI-N6079 Intel Core i9 13980HX 16GB 1TB SSD RTX4070 Freedos 18 WQXGA 240Hz Taşınabilir Bilgisayar",
                            IsDeleted = false,
                            Name = "Oyuncu Bilgisayarı",
                            Point = 10,
                            Price = 74956m,
                            Stock = 78,
                            ThumbnailImage = "/images/asusthumbnail.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Nike",
                            CategoryId = 5,
                            ContentImage = "/images/gscontent1.webp",
                            ContentImage2 = "/images/gscontent2.webp",
                            ContentImage3 = "/images/gscontent3.webp",
                            ContentImage4 = "/images/gscontent4.webp",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 490, DateTimeKind.Local).AddTicks(9764),
                            Description = "Nike Galatasaray 2023/2024 Parçalı İç Saha Forma FN0200-836",
                            IsDeleted = false,
                            Name = "Galatasaray 23-24 Sezonu İç Saha Forma",
                            Point = 10,
                            Price = 1200m,
                            Stock = 500,
                            ThumbnailImage = "/images/gsthumbnail.webp"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Armani",
                            CategoryId = 9,
                            ContentImage = "/images/armanicontent1.webp",
                            ContentImage2 = "/images/armanicontent2.webp",
                            ContentImage3 = "/images/armanicontent3.webp",
                            ContentImage4 = "/images/armanicontent4.webp",
                            DateTime = new DateTime(2023, 12, 24, 1, 1, 12, 490, DateTimeKind.Local).AddTicks(9767),
                            Description = "Giorgio Armani, güçlü ve şehvetli bir iz için aromatik ve odunsu notalara sahip erkekler için yeni doldurulabilir parfümü ARMANI CODE PARFUM'u tanıttı. Yeni ARMANI CODE kokusunu yaratmak için Giorgio Armani, tüm çeşitliliğiyle günümüz erkeğinden ilham aldı. Erkekler daha özgün bir erkeklik ifade etmekte ve duygularıyla daha uyumlu olmakta özgürdür. Bu yeni kodlar, her zaman Giorgio Armani'nin vizyonu olan şeyi somutlaştırıyor: nüanslarla dolu hassas bir erkeklik vizyonu. Usta parfümcü Antoine Maisondieu, ARMANI CODE PARFUM'u yaratarak bu vizyonu aktarıyor. Doğal kökenli ve sürdürülebilir kaynaklardan gelen değerli içerikleri tercih eden olağanüstü ve çevre dostu bir koku. Üst notada, İtalya'daki Calabria'ya özgü bergamot, ışıltılı ve canlı bir tazelik getiriyor. Kalp notasında iris, asil ve zarif, aromatik ve çiçeksi bir imza yaratır. Alt notada tonka fasulyesi mutlak güçlü ve şehvetli bir iz ortaya koyuyor. Yeni ARMANI CODE PARFUM şişesi, modern bir lüks vizyonunu ifade ediyor. Yoğun siyah renkte, kare ve yuvarlak şekilli, şık bir cam tabana sahiptir. Giorgio Armani monogramını taşıyan manyetik kapak, şişeyi tek bir hareketle kapatır. Altındaki gümüş plaka ışığı yakalar ve sofistike bir kontrast sağlar. Giorgio Armani'nin sürdürülebilir kalkınma konusundaki süregelen taahhütlerine uygun olarak, eko tasarımlı ARMANI CODE PARFUM şişesi 150 ml'lik yeniden doldurma sayesinde her boyutta yeniden doldurulabilir.",
                            IsDeleted = false,
                            Name = "Erkek Parfüm",
                            Point = 10,
                            Price = 5990m,
                            Stock = 300,
                            ThumbnailImage = "/images/armanithumbnail.webp"
                        });
                });

            modelBuilder.Entity("Entity.Entities.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("Entity.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Entity.Entities.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SalesDetail");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.CardLine", b =>
                {
                    b.HasOne("Entity.Entities.Card", "Card")
                        .WithMany("CardLines")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entity.Entities.Product", b =>
                {
                    b.HasOne("Entity.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entity.Entities.ProductFeature", b =>
                {
                    b.HasOne("Entity.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entity.Entities.SaleDetail", b =>
                {
                    b.HasOne("Entity.Entities.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Sale", "Sale")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("DataAccess.Identity.Model.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DataAccess.Identity.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DataAccess.Identity.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("DataAccess.Identity.Model.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Identity.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DataAccess.Identity.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Card", b =>
                {
                    b.Navigation("CardLines");
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entity.Entities.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
