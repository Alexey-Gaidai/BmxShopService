using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BmxShopService.Migrations
{
    public partial class testets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_orderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_productId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_orderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_productId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "Ordersid",
                table: "OrderItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Productsid",
                table: "OrderItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Ordersid",
                table: "OrderItems",
                column: "Ordersid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Productsid",
                table: "OrderItems",
                column: "Productsid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Ordersid",
                table: "OrderItems",
                column: "Ordersid",
                principalTable: "Orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_Productsid",
                table: "OrderItems",
                column: "Productsid",
                principalTable: "Products",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Ordersid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_Productsid",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Ordersid",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Productsid",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Ordersid",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Productsid",
                table: "OrderItems");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_orderId",
                table: "OrderItems",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_productId",
                table: "OrderItems",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_orderId",
                table: "OrderItems",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_productId",
                table: "OrderItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
