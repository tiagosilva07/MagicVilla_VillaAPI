using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentityRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a3362c4-2fff-46be-a90e-095d19b368e2", null, "admin", null },
                    { "ceeca003-c437-4963-a882-cdb3521f01e2", null, "customer", null }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2133), new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 5, 17, 15, 43, 16, 543, DateTimeKind.Local).AddTicks(2147) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a3362c4-2fff-46be-a90e-095d19b368e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceeca003-c437-4963-a882-cdb3521f01e2");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6401), new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6420), new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 5, 17, 15, 30, 35, 142, DateTimeKind.Local).AddTicks(6428) });
        }
    }
}
