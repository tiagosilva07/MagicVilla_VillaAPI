using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeDuplicatedUsersRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1c05354-ee9d-4cb0-83ce-33073d16909c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f93c7f74-b2ed-49c4-a881-69cb96683226");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(935), new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(955), new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(961), new DateTime(2023, 5, 17, 23, 13, 11, 15, DateTimeKind.Local).AddTicks(963) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1c05354-ee9d-4cb0-83ce-33073d16909c", null, "customer", null },
                    { "f93c7f74-b2ed-49c4-a881-69cb96683226", null, "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 5, 17, 23, 6, 59, 111, DateTimeKind.Local).AddTicks(5739) });
        }
    }
}
