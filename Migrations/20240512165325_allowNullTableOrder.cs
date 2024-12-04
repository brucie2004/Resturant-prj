using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class allowNullTableOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9515), new DateTime(2024, 5, 12, 19, 23, 25, 313, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 53, 25, 313, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 38, 25, 313, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 23, 25, 313, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 23, 25, 313, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 5, 12, 19, 53, 25, 313, DateTimeKind.Local).AddTicks(9535) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
