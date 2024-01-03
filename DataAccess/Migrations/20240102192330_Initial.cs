﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GivenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AptNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentImage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentImage3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentImage4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commands_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesDetail_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "DateTime", "Description", "IsDeleted" },
                values: new object[,]
                {
                    { 2, "Giyim", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3170), "Erkek - Kadın - Çocuk kıyafet.", false },
                    { 4, "Elektronik", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3172), "Teknolojik araçlar.", false },
                    { 5, "Spor & Outdoor", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3173), "Spor ve dış giyim malzemeleri.", false },
                    { 7, "Ayakkabı", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3174), "Erkek - Kadın - Çocuk ayakkabı.", false },
                    { 9, "Kozmetik", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3175), "Makyaj ve kişisel bakım malzemeleri.", false },
                    { 11, "Ev & Yaşam", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3176), "Ev ve yaşam için gerekli genel malzemeler.", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "ContentImage", "ContentImage2", "ContentImage3", "ContentImage4", "DateTime", "Description", "IsDeleted", "Name", "Point", "Price", "Stock", "ThumbnailImage" },
                values: new object[,]
                {
                    { 1, "NIKE", 7, "/images/content2.webp", "/images/content3.webp", "/images/content0.webp", "/images/content1.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(2994), "Rahatlık ve moda odaklı tasarlanmış şık erkek ayakkabısı. Bu NIKE Air-Force ayakkabıları, günlük veya spor giyim için mükemmel bir seçenek sunar.", false, "Air-Force Ayakkabı", 10, 2500m, 50, "/images/thumbnail.webp" },
                    { 2, "NIKE", 7, "/images/NikeCortez1.webp", "/images/NikeCortez2.webp", "/images/NikeCortez3.webp", "/images/NikeCortez4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(2998), "Stil ve işlevselliğe odaklanan NIKE tarafından tasarlanmış şık kadın ayakkabıları. Nike-Cortez koleksiyonu, günlük giyim için moda ve konforu mükemmel bir şekilde birleştiriyor.", false, "Nike-Cortez Ayakkabı", 10, 3499m, 50, "/images/NikeCortez.webp" },
                    { 3, "NIKE", 7, "/images/NikeCortez2.webp", "/images/NikeV2KRun3.webp", "/images/NikeV2KRun4.webp", "/images/NikeV2KRun1.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3000), "NIKE, aktif bir yaşam tarzı için tasarlanmış kadın ayakkabısı olan V2 Run'u sunar. Bu rahat ve dayanıklı koşu ayakkabıları ile performans ve stilin tadını çıkarın.", false, "Nike V2 Run Ayakkabı", 10, 2999m, 50, "/images/NikeV2KRun.webp" },
                    { 4, "NIKE", 7, "/images/NikeAirMax90Futura2.webp", "/images/NikeAirMax90Futura3.webp", "/images/NikeAirMax90Futura4.webp", "/images/NikeAirMax90Futura5.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3002), " Moda ve sporu bir araya getiren, kadınlar için ideal olan Nike AirMax 90 Futura. Bu ayakkabılar şık tasarımı ve gün boyu konforu ile öne çıkıyor.", false, "Nike AirMax 90 Futura Ayakkabı", 10, 1499m, 110, "/images/NikeAirMax90Futura1.webp" },
                    { 5, "NIKE", 7, "/images/NikeCourtVısıonLo2.jpg", "/images/NikeCourtVısıonLo3.jpg", "/images/NikeCourtVısıonLo4.jpg", "/images/NikeCourtVısıonLo5.jpg", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3004), "Stilin bir dokunuşuyla erkek spor ayakkabıları. Nike Court Vısıon Lo koleksiyonu, spor ve günlük kullanım için performans ile trend tasarımı mükemmel bir şekilde birleştiriyor.", false, "Nike Court Vısıon Lo Ayakkabı", 10, 4999m, 150, "/images/NikeCourtVısıonLo1.jpg" },
                    { 6, "adidas", 7, "/images/stansmith1.webp", "/images/stansmith2.webp", "/images/stansmith3.webp", "/images/stansmith4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3006), "Klasik erkek ayakkabılarından olan adidas Stan Smith koleksiyonu, zamansız stili ve konforuyla bilinir. Bu ikonik sneaker'lar ile günlük görünümünüzü yükseltin.", false, "adidas Stan Smith Ayakkabı", 10, 1849m, 150, "/images/stansmith.webp" },
                    { 7, "adidas", 7, "/images/adidasniteball1.webp", "/images/adidasniteball2.webp", "/images/adidasniteball3.webp", "/images/adidasniteball4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3008), "adidas'ın tasarladığı cinsiyet ayrımı olmayan spor ayakkabıları, Niteball koleksiyonu, çok yönlülük ve performans için tasarlanmıştır. Bu ayakkabılar çeşitli spor ve aktiviteler için uygundur.", false, "adidas niteball unisex Ayakkabı", 10, 1849m, 150, "/images/adidasniteball.webp" },
                    { 8, "NewBalance", 7, "/images/NewBalance5301.webp", "/images/NewBalance5302.webp", "/images/NewBalance5305.webp", "/images/NewBalance5304.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3010), "NewBalance530 erkek ayakkabıları ile stil sahibi bir şekilde doğayı keşfedin. Bu NewBalance sneaker'lar, sert dayanıklılık ve modern tasarımın mükemmel bir kombinasyonunu sunar, aktif yaşam tarzınız için.", false, "NewBalance530 Ayakkabı", 10, 3599m, 45, "/images/NewBalance530.webp" },
                    { 9, "Yves Saint Laurent", 9, "/images/YSLLEauDeParfum1.webp", "/images/YSLLEauDeParfum2.webp", "/images/YSLLEauDeParfum3.webp", "/images/YSLLEauDeParfum4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3012), "", false, "Yves Saint Laurent Libre Eau De Parfum 30 ml", 10, 4099m, 50, "/images/YSLLEauDeParfum.webp" },
                    { 10, "Yves Saint Laurent", 9, "/images/YSLLHomme1.webp", "/images/YSLLHomme2.webp", "/images/YSLLHomme3.webp", "/images/YSLLHomme4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3014), "", false, "Yves Saint Laurent L'Homme Le Parfum Edp 100 ml", 10, 3399m, 50, "/images/YSLLHomme.webp" },
                    { 11, "Armani", 9, "/images/armanicontent1.webp", "/images/armanicontent2.webp", "/images/armanicontent3.webp", "/images/armanicontent4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3016), "Giorgio Armani, güçlü ve şehvetli bir iz için aromatik ve odunsu notalara sahip erkekler için yeni doldurulabilir parfümü ARMANI CODE PARFUM'u tanıttı.", false, "Erkek Parfüm", 10, 5990m, 300, "/images/armanithumbnail.webp" },
                    { 12, "Yves Saint Laurent", 9, "/images/YSLMonParis1.webp", "/images/YSLMonParis2.webp", "/images/YSLMonParis3.webp", "/images/YSLMonParis4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3018), "", false, "Yves Saint Laurent Mon Paris Parfum Edp 30 ml", 10, 6049m, 50, "/images/YSLMonParis.webp" },
                    { 13, "Clinique", 9, "/images/Clinique1.webp", "/images/Clinique2.webp", "/images/Clinique3.webp", "/images/Clinique4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3022), "", false, "Clinique Moisture Surge 100 Saat Etkili Nemlendirici 15 ml", 10, 350m, 50, "/images/Clinique.webp" },
                    { 14, "M.A.C", 9, "/images/MacRuj1.webp", "/images/MacRuj2.webp", "/images/MacRuj3.webp", "/images/MacRuj4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3049), "", false, "Mac Ruj / Lipstick - Velvet Teddy", 10, 350m, 50, "/images/MacRuj.webp" },
                    { 15, "DS Damat", 2, "/images/takımcontent1.webp", "/images/takımcontent2.webp", "/images/takımcontent3.webp", "/images/takımcontent4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3051), "Slim Fit Siyah Düz Takim Elbise", false, "Erkek Takım Elbise", 10, 9999m, 120, "/images/takımthubnail.webp" },
                    { 16, "Asus ROG", 4, "/images/ProArt1.jpeg", "/images/ProArt2.jpeg", "/images/ProArt3.jpeg", "/images/ProArt4.jpeg", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3053), "ProArt Display PA279CRV, profesyonel video editörleri için tasarlanan 27 inç 4K HDR bir monitördür. Calman Verified sertifikasına sahip ekran, %99 DCI-P3 geniş renk gamı, %99 Adobe RGB kapsaması ve olağanüstü renk doğruluğu için fabrikada kalibre edilen Delta E < 2 sunar. Ek kolaylıklar sağlamak için dahili USB-C® bağlantı noktası DisplayPort™, süper hızlı veri aktarımları ve tek kablo üzerinden 96-watt güç dağıtımı desteği sunar.", false, "ASUS ProArt PA279CRV 27″ 5ms 60Hz Gaming Monitör", 10, 24956m, 78, "/images/ProArt.jpeg" },
                    { 17, "Asus ROG", 4, "/images/asuscontent1.jpeg", "/images/asuscontent2.jpeg", "/images/asuscontent3.jpeg", "/images/asuscontent4.jpeg", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3055), "Asus ROG Strix G18 G814JI-N6079 Intel Core i9 13980HX 16GB 1TB SSD RTX4070 Freedos 18 WQXGA 240Hz Taşınabilir Bilgisayar", false, "Oyuncu Bilgisayarı", 10, 74956m, 78, "/images/asusthumbnail.jpeg" },
                    { 18, "Asus ROG", 4, "/images/RTX40801.jpg", "/images/RTX40802.jpg", "/images/RTX40803.jpg", "/images/RTX40804.jpg", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3057), "", false, "Asus GeForce RTX 4080 Noctua OC 16G GDDR6X 256Bit DX12 DLSS 3 Gaming (Oyuncu) Ekran Kartı", 10, 74956m, 78, "/images/RTX4080.jpg" },
                    { 19, "Nike", 5, "/images/gscontent1.webp", "/images/gscontent2.webp", "/images/gscontent3.webp", "/images/gscontent4.webp", new DateTime(2024, 1, 2, 22, 23, 30, 912, DateTimeKind.Local).AddTicks(3059), "Nike Galatasaray 2023/2024 Parçalı İç Saha Forma FN0200-836", false, "Galatasaray 23-24 Sezonu İç Saha Forma", 10, 1200m, 500, "/images/gsthumbnail.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_ProductId",
                table: "Commands",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetail_ProductId",
                table: "SalesDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetail_SaleId",
                table: "SalesDetail",
                column: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Commands");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "SalesDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}