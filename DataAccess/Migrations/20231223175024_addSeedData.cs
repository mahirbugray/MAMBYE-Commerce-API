using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "ContentImage", "ContentImage2", "ContentImage3", "ContentImage4", "DateTime", "Description", "IsDeleted", "Name", "Point", "Price", "Stock", "ThumbnailImage" },
                values: new object[,]
                {
                    { 2, "DS Damat", 2, "/images/takımcontent1.webp", "/images/takımcontent2.webp", "/images/takımcontent3.webp", "/images/takımcontent4.webp", new DateTime(2023, 12, 23, 20, 50, 23, 926, DateTimeKind.Local).AddTicks(5028), "Slim Fit Siyah Düz Takim Elbise", false, "Erkek Takım Elbise", 10, 9999m, 120, "/images/takımthubnail.webp" },
                    { 3, "Asus ROG", 4, "/images/asuscontent1.jpeg", "/images/asuscontent2.jpeg", "/images/asuscontent3.jpeg", "/images/asuscontent4.jpeg", new DateTime(2023, 12, 23, 20, 50, 23, 926, DateTimeKind.Local).AddTicks(5032), "Asus ROG Strix G18 G814JI-N6079 Intel Core i9 13980HX 16GB 1TB SSD RTX4070 Freedos 18 WQXGA 240Hz Taşınabilir Bilgisayar", false, "Oyuncu Bilgisayarı", 10, 74956m, 78, "/images/asusthumbnail.jpeg" },
                    { 4, "Nike", 5, "/images/gscontent1.webp", "/images/gscontent2.webp", "/images/gscontent3.webp", "/images/gscontent4.webp", new DateTime(2023, 12, 23, 20, 50, 23, 926, DateTimeKind.Local).AddTicks(5034), "Nike Galatasaray 2023/2024 Parçalı İç Saha Forma FN0200-836", false, "Galatasaray 23-24 Sezonu İç Saha Forma", 10, 1200m, 500, "/images/gsthumbnail.webp" },
                    { 5, "Armani", 9, "/images/armanicontent1.webp", "/images/armanicontent2.webp", "/images/armanicontent3.webp", "/images/armanicontent4.webp", new DateTime(2023, 12, 23, 20, 50, 23, 926, DateTimeKind.Local).AddTicks(5037), "Giorgio Armani, güçlü ve şehvetli bir iz için aromatik ve odunsu notalara sahip erkekler için yeni doldurulabilir parfümü ARMANI CODE PARFUM'u tanıttı. Yeni ARMANI CODE kokusunu yaratmak için Giorgio Armani, tüm çeşitliliğiyle günümüz erkeğinden ilham aldı. Erkekler daha özgün bir erkeklik ifade etmekte ve duygularıyla daha uyumlu olmakta özgürdür. Bu yeni kodlar, her zaman Giorgio Armani'nin vizyonu olan şeyi somutlaştırıyor: nüanslarla dolu hassas bir erkeklik vizyonu. Usta parfümcü Antoine Maisondieu, ARMANI CODE PARFUM'u yaratarak bu vizyonu aktarıyor. Doğal kökenli ve sürdürülebilir kaynaklardan gelen değerli içerikleri tercih eden olağanüstü ve çevre dostu bir koku. Üst notada, İtalya'daki Calabria'ya özgü bergamot, ışıltılı ve canlı bir tazelik getiriyor. Kalp notasında iris, asil ve zarif, aromatik ve çiçeksi bir imza yaratır. Alt notada tonka fasulyesi mutlak güçlü ve şehvetli bir iz ortaya koyuyor. Yeni ARMANI CODE PARFUM şişesi, modern bir lüks vizyonunu ifade ediyor. Yoğun siyah renkte, kare ve yuvarlak şekilli, şık bir cam tabana sahiptir. Giorgio Armani monogramını taşıyan manyetik kapak, şişeyi tek bir hareketle kapatır. Altındaki gümüş plaka ışığı yakalar ve sofistike bir kontrast sağlar. Giorgio Armani'nin sürdürülebilir kalkınma konusundaki süregelen taahhütlerine uygun olarak, eko tasarımlı ARMANI CODE PARFUM şişesi 150 ml'lik yeniden doldurma sayesinde her boyutta yeniden doldurulabilir.", false, "Erkek Parfüm", 10, 5990m, 300, "/images/armanithumbnail.webp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
