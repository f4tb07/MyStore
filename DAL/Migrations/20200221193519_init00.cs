using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CateuryTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateuryTbl", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inStoreCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    Discription = table.Column<string>(maxLength: 500, nullable: true),
                    CurrentPrice = table.Column<double>(nullable: false),
                    CateguryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_CateuryTbl_CateguryID",
                        column: x => x.CateguryID,
                        principalTable: "CateuryTbl",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OffTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    RelatedProductID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffTbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OffTbl_Products_RelatedProductID",
                        column: x => x.RelatedProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PriceTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RgisterDate = table.Column<DateTime>(nullable: false),
                    Todate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    RelatedProductID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceTbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PriceTbl_Products_RelatedProductID",
                        column: x => x.RelatedProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImageTbl",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(nullable: true),
                    RelatedItemID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImageTbl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductImageTbl_Products_RelatedItemID",
                        column: x => x.RelatedItemID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OffTbl_RelatedProductID",
                table: "OffTbl",
                column: "RelatedProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PriceTbl_RelatedProductID",
                table: "PriceTbl",
                column: "RelatedProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageTbl_RelatedItemID",
                table: "ProductImageTbl",
                column: "RelatedItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CateguryID",
                table: "Products",
                column: "CateguryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffTbl");

            migrationBuilder.DropTable(
                name: "PriceTbl");

            migrationBuilder.DropTable(
                name: "ProductImageTbl");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CateuryTbl");
        }
    }
}
