using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SaleDetailPropEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AptNumber",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardOwner",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighbourhood",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "SalesDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 23, 35, 46, 887, DateTimeKind.Local).AddTicks(8434));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AptNumber",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "CardOwner",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "City",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "Neighbourhood",
                table: "SalesDetail");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "SalesDetail");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2023, 12, 28, 21, 33, 16, 640, DateTimeKind.Local).AddTicks(4133));
        }
    }
}
