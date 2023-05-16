using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(227), "https://dotnetmastery.com/bluevillaimages/villa3.jpg", new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(234), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(240), "https://dotnetmastery.com/bluevillaimages/villa4.jpg", new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(246), "https://dotnetmastery.com/bluevillaimages/villa5.jpg", new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(253), "https://dotnetmastery.com/bluevillaimages/villa2.jpg", new DateTime(2023, 5, 15, 15, 39, 16, 734, DateTimeKind.Local).AddTicks(254) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(156), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(163), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(169), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(175), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(182), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", new DateTime(2023, 5, 11, 13, 0, 54, 116, DateTimeKind.Local).AddTicks(183) });
        }
    }
}
