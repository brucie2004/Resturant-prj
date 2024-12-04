using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class seedTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 5, 12, 10, 1, 31, 689, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 11, 31, 31, 689, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 11, 16, 31, 689, DateTimeKind.Local).AddTicks(8617), new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 11, 1, 31, 689, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "AccessDate", "DeliverState", "DeliveryEmployer", "NumberOfItems", "OrderDate", "Price", "TableId", "Type" },
                values: new object[] { 8, new DateTime(2024, 5, 12, 11, 1, 31, 689, DateTimeKind.Local).AddTicks(8624), false, 1, 4, new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8623), 400.0, 6, "VIP" });

            migrationBuilder.InsertData(
                table: "orders_foodrinks",
                columns: new[] { "Id", "FoodrinkId", "OrderId" },
                values: new object[,]
                {
                    { 12, 1, 8 },
                    { 13, 1, 8 },
                    { 14, 2, 8 },
                    { 15, 2, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 9, 37, 30, 896, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 5, 12, 9, 7, 30, 896, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 10, 37, 30, 896, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 5, 12, 9, 37, 30, 896, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 10, 22, 30, 896, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 5, 12, 9, 37, 30, 896, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 10, 7, 30, 896, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 5, 12, 9, 37, 30, 896, DateTimeKind.Local).AddTicks(247) });
        }
    }
}
