using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class commandEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "Commands");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 22, 1, 49, 693, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.CreateIndex(
                name: "IX_Commands_ProductId",
                table: "Commands",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Products_ProductId",
                table: "Commands",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Products_ProductId",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_ProductId",
                table: "Commands");

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 29, 22, 11, 23, 319, DateTimeKind.Local).AddTicks(6566));
        }
    }
}
