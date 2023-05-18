using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addApplicationUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4ef3ac4-837a-4e68-92b2-db9fffb7160a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0547f45-5599-41a8-afad-963a8375fd43");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "admin", "ADMINISTRATOR" },
                    { "3c5e174e-3b0e-446f-86af-493d56fd7210", null, "customer", "CUSTOMER" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c5e174e-3b0e-446f-86af-493d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1c05354-ee9d-4cb0-83ce-33073d16909c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f93c7f74-b2ed-49c4-a881-69cb96683226");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b4ef3ac4-837a-4e68-92b2-db9fffb7160a", null, "admin", null },
                    { "c0547f45-5599-41a8-afad-963a8375fd43", null, "customer", null }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 5, 17, 22, 45, 25, 169, DateTimeKind.Local).AddTicks(9028) });
        }
    }
}
