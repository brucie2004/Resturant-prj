using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class finalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders_foodrinks");

            migrationBuilder.CreateTable(
                name: "FoodrinkOrder",
                columns: table => new
                {
                    foodrinksId = table.Column<int>(type: "int", nullable: false),
                    ordersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodrinkOrder", x => new { x.foodrinksId, x.ordersId });
                    table.ForeignKey(
                        name: "FK_FoodrinkOrder_foodrinks_foodrinksId",
                        column: x => x.foodrinksId,
                        principalTable: "foodrinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodrinkOrder_orders_ordersId",
                        column: x => x.ordersId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 5, 8, 19, 23, 29, 846, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 53, 29, 846, DateTimeKind.Local).AddTicks(4865), new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 38, 29, 846, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 23, 29, 846, DateTimeKind.Local).AddTicks(4871), new DateTime(2024, 5, 8, 19, 53, 29, 846, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.CreateIndex(
                name: "IX_FoodrinkOrder_ordersId",
                table: "FoodrinkOrder",
                column: "ordersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodrinkOrder");

            migrationBuilder.CreateTable(
                name: "orders_foodrinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodrinkId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_foodrinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_foodrinks_foodrinks_FoodrinkId",
                        column: x => x.FoodrinkId,
                        principalTable: "foodrinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_foodrinks_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 5, 4, 11, 59, 11, 661, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 4, 13, 29, 11, 661, DateTimeKind.Local).AddTicks(1977), new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 4, 13, 14, 11, 661, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 4, 12, 59, 11, 661, DateTimeKind.Local).AddTicks(1983), new DateTime(2024, 5, 4, 12, 29, 11, 661, DateTimeKind.Local).AddTicks(1982) });

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

            migrationBuilder.CreateIndex(
                name: "IX_orders_foodrinks_FoodrinkId",
                table: "orders_foodrinks",
                column: "FoodrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_foodrinks_OrderId",
                table: "orders_foodrinks",
                column: "OrderId");
        }
    }
}
