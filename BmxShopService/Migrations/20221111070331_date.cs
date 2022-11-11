using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BmxShopService.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserLogin",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "purchaseDate",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserLogin",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "purchaseDate",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }
    }
}
