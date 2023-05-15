using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

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
    }
}
