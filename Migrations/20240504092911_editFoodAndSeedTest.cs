using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class editFoodAndSeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "foodrinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "cold drink" },
                    { 2, "hot drink" },
                    { 3, "main meal" },
                    { 4, "treat" }
                });

            migrationBuilder.InsertData(
                table: "employers",
                columns: new[] { "Id", "Address", "Age", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "jesr al-abiad", 22, "Ahmed Jalal", "0947675777" },
                    { 2, "afif", 23, "Emad Khayat", "0933431567" },
                    { 3, "midan", 19, "Bilal Tahan", "0968793347" },
                    { 4, "shaghour", 33, "Bahaa Nahas", "0928139925" }
                });

            migrationBuilder.InsertData(
                table: "tables",
                columns: new[] { "Id", "Floor", "Number", "State" },
                values: new object[,]
                {
                    { 1, 1, 1, false },
                    { 2, 1, 2, true },
                    { 3, 1, 3, true },
                    { 4, 2, 1, false },
                    { 5, 2, 2, false },
                    { 6, 2, 3, true }
                });

            migrationBuilder.InsertData(
                table: "foodrinks",
                columns: new[] { "Id", "CategoryId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, "cheese cake", 200.0, 100 },
                    { 2, 3, "chicken", 250.0, 80 },
                    { 3, 1, "cola", 50.0, 400 },
                    { 4, 2, "coffee", 70.0, 500 },
                    { 5, 3, "pizza", 150.0, 120 }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "AccessDate", "DeliverState", "DeliveryEmployer", "NumberOfItems", "OrderDate", "Price", "TableId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1971), true, 1, 2, new DateTime(2024, 5, 4, 11, 59, 11, 661, DateTimeKind.Local).AddTicks(1920), 500.0, 6, "VIP" },
                    { 2, new DateTime(2024, 5, 4, 13, 29, 11, 661, DateTimeKind.Local).AddTicks(1977), false, 2, 4, new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1976), 200.0, 3, "ordinary" },
                    { 3, new DateTime(2024, 5, 4, 13, 14, 11, 661, DateTimeKind.Local).AddTicks(1980), false, 2, 3, new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1979), 350.0, 2, "ordinary" },
                    { 4, new DateTime(2024, 5, 4, 12, 59, 11, 661, DateTimeKind.Local).AddTicks(1983), false, 1, 2, new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1982), 400.0, 6, "VIP" }
                });

            migrationBuilder.InsertData(
                table: "orders_foodrinks",
                columns: new[] { "Id", "FoodrinkId", "OrderId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 3, 2 },
                    { 5, 3, 2 },
                    { 6, 3, 2 },
                    { 7, 5, 3 },
                    { 8, 5, 3 },
                    { 9, 5, 3 },
                    { 10, 1, 4 },
                    { 11, 1, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "employers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "employers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "employers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "foodrinks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "orders_foodrinks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "foodrinks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "foodrinks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "foodrinks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "foodrinks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "foodrinks");
        }
    }
}
