using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class outerTableOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 14, 42, 416, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 5, 12, 19, 44, 42, 416, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 14, 42, 416, DateTimeKind.Local).AddTicks(9759), new DateTime(2024, 5, 12, 20, 14, 42, 416, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 59, 42, 416, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 5, 12, 20, 14, 42, 416, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 44, 42, 416, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 5, 12, 20, 14, 42, 416, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 12, 20, 44, 42, 416, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 5, 12, 20, 14, 42, 416, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.InsertData(
                table: "tables",
                columns: new[] { "Id", "Floor", "Number", "State" },
                values: new object[] { 7, 0, 0, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
