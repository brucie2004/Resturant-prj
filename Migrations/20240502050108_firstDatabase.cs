using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class firstDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "foodrinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodrinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_foodrinks_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliverState = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryEmployer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    NumberOfItems = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_tables_TableId",
                        column: x => x.TableId,
                        principalTable: "tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_foodrinks_CategoryId",
                table: "foodrinks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_TableId",
                table: "orders",
                column: "TableId");

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
                name: "employers");

            migrationBuilder.DropTable(
                name: "orders_foodrinks");

            migrationBuilder.DropTable(
                name: "foodrinks");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "tables");
        }
    }
}
