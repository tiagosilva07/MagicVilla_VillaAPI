using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullableToFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(156), new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(183) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 5, 11, 9, 32, 49, 487, DateTimeKind.Local).AddTicks(1120) });
        }
    }
}
