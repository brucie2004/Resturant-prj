using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class returningManually : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodrinkOrder");

            migrationBuilder.CreateTable(
                name: "orders_foodrinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    FoodrinkId = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 5, 12, 3, 55, 2, 76, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 5, 12, 3, 25, 2, 76, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 55, 2, 76, DateTimeKind.Local).AddTicks(3824), new DateTime(2024, 5, 12, 3, 55, 2, 76, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 40, 2, 76, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 5, 12, 3, 55, 2, 76, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 25, 2, 76, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 5, 12, 3, 55, 2, 76, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.CreateIndex(
                name: "IX_FoodrinkOrder_ordersId",
                table: "FoodrinkOrder",
                column: "ordersId");
        }
    }
}
