using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 38, 50, 538, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 5, 10, 17, 38, 50, 539, DateTimeKind.Local).AddTicks(26) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7721), new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7726), new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 5, 10, 11, 52, 8, 315, DateTimeKind.Local).AddTicks(7739) });
        }
    }
}
