using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class isUniqueMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "employers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "employers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 19, 45, 33, 729, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 5, 12, 19, 15, 33, 729, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 45, 33, 729, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 5, 12, 19, 45, 33, 729, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 30, 33, 729, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 5, 12, 19, 45, 33, 729, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 15, 33, 729, DateTimeKind.Local).AddTicks(5139), new DateTime(2024, 5, 12, 19, 45, 33, 729, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 15, 33, 729, DateTimeKind.Local).AddTicks(5143), new DateTime(2024, 5, 12, 19, 45, 33, 729, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.CreateIndex(
                name: "IX_employers_Name",
                table: "employers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employers_Phone",
                table: "employers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_Name",
                table: "categories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_employers_Name",
                table: "employers");

            migrationBuilder.DropIndex(
                name: "IX_employers_Phone",
                table: "employers");

            migrationBuilder.DropIndex(
                name: "IX_categories_Name",
                table: "categories");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "employers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "employers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 19, 41, 50, 351, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 5, 12, 19, 11, 50, 351, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 41, 50, 351, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 5, 12, 19, 41, 50, 351, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 26, 50, 351, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 5, 12, 19, 41, 50, 351, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 11, 50, 351, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 5, 12, 19, 41, 50, 351, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 11, 50, 351, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 5, 12, 19, 41, 50, 351, DateTimeKind.Local).AddTicks(1017) });
        }
    }
}
