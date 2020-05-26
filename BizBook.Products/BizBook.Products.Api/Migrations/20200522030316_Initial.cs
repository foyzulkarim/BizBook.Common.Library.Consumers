using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizBook.Products.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(128)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    CreatedFrom = table.Column<string>(type: "varchar(32)", nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ShopId = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(128)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    CreatedFrom = table.Column<string>(type: "varchar(32)", nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ShopId = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", nullable: false),
                    ProductGroupId = table.Column<string>(type: "varchar(128)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(128)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    CreatedFrom = table.Column<string>(type: "varchar(32)", nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ShopId = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", nullable: false),
                    BarCode = table.Column<string>(type: "varchar(128)", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(128)", nullable: false),
                    Brand = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsRawProduct = table.Column<bool>(nullable: false),
                    HasUniqueSerial = table.Column<bool>(nullable: false),
                    UniqueSerial = table.Column<string>(type: "varchar(128)", nullable: true),
                    SalePrice = table.Column<double>(nullable: false),
                    DealerPrice = table.Column<double>(nullable: false),
                    CostPrice = table.Column<double>(nullable: false),
                    DealerCashPrice = table.Column<double>(nullable: false),
                    DealerDuePrice = table.Column<double>(nullable: false),
                    FranchisePrice = table.Column<double>(nullable: false),
                    PartnershipPrice = table.Column<double>(nullable: false),
                    StartingInventory = table.Column<int>(nullable: false),
                    Purchased = table.Column<double>(nullable: false),
                    Sold = table.Column<double>(nullable: false),
                    OnHand = table.Column<double>(nullable: false),
                    MinimumStockToNotify = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatedBy",
                table: "ProductCategories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedFrom",
                table: "ProductCategories",
                column: "CreatedFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Name",
                table: "ProductCategories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductGroupId",
                table: "ProductCategories",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopId",
                table: "ProductCategories",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_BarCode",
                table: "ProductDetails",
                column: "BarCode");

            migrationBuilder.CreateIndex(
                name: "IX_Brand",
                table: "ProductDetails",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedBy",
                table: "ProductDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedFrom",
                table: "ProductDetails",
                column: "CreatedFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Name",
                table: "ProductDetails",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductCategoryId",
                table: "ProductDetails",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCode",
                table: "ProductDetails",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_ShopId",
                table: "ProductDetails",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_UniqueSerial",
                table: "ProductDetails",
                column: "UniqueSerial");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedBy",
                table: "ProductGroups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedFrom",
                table: "ProductGroups",
                column: "CreatedFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Name",
                table: "ProductGroups",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ShopId",
                table: "ProductGroups",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductGroups");
        }
    }
}
