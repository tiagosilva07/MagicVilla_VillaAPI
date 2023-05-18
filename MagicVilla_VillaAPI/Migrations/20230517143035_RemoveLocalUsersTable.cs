using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLocalUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3793), new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3809), new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3822), new DateTime(2023, 5, 17, 15, 3, 23, 722, DateTimeKind.Local).AddTicks(3823) });
        }
    }
}
