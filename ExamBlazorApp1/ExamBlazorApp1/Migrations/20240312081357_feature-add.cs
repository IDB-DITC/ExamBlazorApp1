using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamBlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class featureadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "MFD",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 31,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 32,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 33,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 34,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 35,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 36,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 37,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 38,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 39,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 40,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 41,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 42,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 43,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 44,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 45,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 46,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 47,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 48,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 49,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 50,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 51,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 52,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 53,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 54,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 55,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 56,
                columns: new[] { "Available", "MFD" },
                values: new object[] { false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MFD",
                table: "Product");
        }
    }
}
