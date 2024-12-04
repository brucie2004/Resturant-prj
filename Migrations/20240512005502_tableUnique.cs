using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class tableUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_tables_Number_Floor",
                table: "tables",
                columns: new[] { "Number", "Floor" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tables_Number_Floor",
                table: "tables");

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
        }
    }
}
