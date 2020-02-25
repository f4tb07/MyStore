using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImageTbl_Products_RelatedItemID",
                table: "ProductImageTbl");

            migrationBuilder.DropIndex(
                name: "IX_ProductImageTbl_RelatedItemID",
                table: "ProductImageTbl");

            migrationBuilder.DropColumn(
                name: "RelatedItemID",
                table: "ProductImageTbl");

            migrationBuilder.AddColumn<int>(
                name: "RelatedProductID",
                table: "ProductImageTbl",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageTbl_RelatedProductID",
                table: "ProductImageTbl",
                column: "RelatedProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImageTbl_Products_RelatedProductID",
                table: "ProductImageTbl",
                column: "RelatedProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImageTbl_Products_RelatedProductID",
                table: "ProductImageTbl");

            migrationBuilder.DropIndex(
                name: "IX_ProductImageTbl_RelatedProductID",
                table: "ProductImageTbl");

            migrationBuilder.DropColumn(
                name: "RelatedProductID",
                table: "ProductImageTbl");

            migrationBuilder.AddColumn<int>(
                name: "RelatedItemID",
                table: "ProductImageTbl",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageTbl_RelatedItemID",
                table: "ProductImageTbl",
                column: "RelatedItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImageTbl_Products_RelatedItemID",
                table: "ProductImageTbl",
                column: "RelatedItemID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
