using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Project.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_TableId",
                table: "orders");

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccessDate",
                table: "orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 2, 20, 9, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 5, 13, 10, 32, 20, 9, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 2, 20, 9, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 5, 13, 11, 2, 20, 9, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 47, 20, 9, DateTimeKind.Local).AddTicks(4420), new DateTime(2024, 5, 13, 11, 2, 20, 9, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 32, 20, 9, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 5, 13, 11, 2, 20, 9, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccessDate", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 32, 20, 9, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 5, 13, 11, 2, 20, 9, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_TableId",
                table: "orders",
                column: "TableId",
                principalTable: "tables",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_TableId",
                table: "orders");

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccessDate",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_TableId",
                table: "orders",
                column: "TableId",
                principalTable: "tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
