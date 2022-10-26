using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BmxShopService.Migrations
{
    public partial class tessss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_manufacturerId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "manufacturerId",
                table: "Products",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_manufacturerId",
                table: "Products",
                newName: "IX_Products_ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Manufacturers",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Products",
                newName: "manufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                newName: "IX_Products_manufacturerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manufacturers",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_manufacturerId",
                table: "Products",
                column: "manufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
