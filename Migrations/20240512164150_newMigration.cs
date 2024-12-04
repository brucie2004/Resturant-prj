using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "foodrinks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 1,
                column: "State",
                value: true);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 2,
                column: "State",
                value: false);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 3,
                column: "State",
                value: false);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 4,
                column: "State",
                value: true);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 5,
                column: "State",
                value: true);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 6,
                column: "State",
                value: false);

            migrationBuilder.CreateIndex(
                name: "IX_foodrinks_Name",
                table: "foodrinks",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_foodrinks_Name",
                table: "foodrinks");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "foodrinks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 11, 1, 31, 689, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 5, 12, 10, 31, 31, 689, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 1,
                column: "State",
                value: false);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 2,
                column: "State",
                value: true);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 3,
                column: "State",
                value: true);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 4,
                column: "State",
                value: false);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 5,
                column: "State",
                value: false);

            migrationBuilder.UpdateData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 6,
                column: "State",
                value: true);
        }
    }
}
