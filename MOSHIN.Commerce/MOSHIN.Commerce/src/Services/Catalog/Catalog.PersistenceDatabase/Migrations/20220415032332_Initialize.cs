﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.PersistenceDatabase.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 554m },
                    { 73, "Description for product 73", "Product 73", 556m },
                    { 72, "Description for product 72", "Product 72", 814m },
                    { 71, "Description for product 71", "Product 71", 298m },
                    { 70, "Description for product 70", "Product 70", 308m },
                    { 69, "Description for product 69", "Product 69", 381m },
                    { 68, "Description for product 68", "Product 68", 463m },
                    { 67, "Description for product 67", "Product 67", 957m },
                    { 66, "Description for product 66", "Product 66", 528m },
                    { 65, "Description for product 65", "Product 65", 384m },
                    { 64, "Description for product 64", "Product 64", 691m },
                    { 63, "Description for product 63", "Product 63", 271m },
                    { 62, "Description for product 62", "Product 62", 766m },
                    { 61, "Description for product 61", "Product 61", 755m },
                    { 60, "Description for product 60", "Product 60", 225m },
                    { 59, "Description for product 59", "Product 59", 851m },
                    { 58, "Description for product 58", "Product 58", 362m },
                    { 57, "Description for product 57", "Product 57", 571m },
                    { 56, "Description for product 56", "Product 56", 736m },
                    { 55, "Description for product 55", "Product 55", 611m },
                    { 54, "Description for product 54", "Product 54", 360m },
                    { 53, "Description for product 53", "Product 53", 722m },
                    { 74, "Description for product 74", "Product 74", 975m },
                    { 52, "Description for product 52", "Product 52", 521m },
                    { 75, "Description for product 75", "Product 75", 311m },
                    { 77, "Description for product 77", "Product 77", 900m },
                    { 98, "Description for product 98", "Product 98", 325m },
                    { 97, "Description for product 97", "Product 97", 453m },
                    { 96, "Description for product 96", "Product 96", 984m },
                    { 95, "Description for product 95", "Product 95", 789m },
                    { 94, "Description for product 94", "Product 94", 389m },
                    { 93, "Description for product 93", "Product 93", 401m },
                    { 92, "Description for product 92", "Product 92", 740m },
                    { 91, "Description for product 91", "Product 91", 313m },
                    { 90, "Description for product 90", "Product 90", 114m },
                    { 89, "Description for product 89", "Product 89", 946m },
                    { 88, "Description for product 88", "Product 88", 862m },
                    { 87, "Description for product 87", "Product 87", 217m },
                    { 86, "Description for product 86", "Product 86", 764m },
                    { 85, "Description for product 85", "Product 85", 440m },
                    { 84, "Description for product 84", "Product 84", 621m },
                    { 83, "Description for product 83", "Product 83", 465m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 813m },
                    { 81, "Description for product 81", "Product 81", 414m },
                    { 80, "Description for product 80", "Product 80", 731m },
                    { 79, "Description for product 79", "Product 79", 889m },
                    { 78, "Description for product 78", "Product 78", 591m },
                    { 76, "Description for product 76", "Product 76", 447m },
                    { 51, "Description for product 51", "Product 51", 980m },
                    { 50, "Description for product 50", "Product 50", 654m },
                    { 49, "Description for product 49", "Product 49", 249m },
                    { 22, "Description for product 22", "Product 22", 818m },
                    { 21, "Description for product 21", "Product 21", 972m },
                    { 20, "Description for product 20", "Product 20", 962m },
                    { 19, "Description for product 19", "Product 19", 519m },
                    { 18, "Description for product 18", "Product 18", 971m },
                    { 17, "Description for product 17", "Product 17", 967m },
                    { 16, "Description for product 16", "Product 16", 301m },
                    { 15, "Description for product 15", "Product 15", 994m },
                    { 14, "Description for product 14", "Product 14", 133m },
                    { 13, "Description for product 13", "Product 13", 921m },
                    { 12, "Description for product 12", "Product 12", 179m },
                    { 11, "Description for product 11", "Product 11", 368m },
                    { 10, "Description for product 10", "Product 10", 571m },
                    { 9, "Description for product 9", "Product 9", 112m },
                    { 8, "Description for product 8", "Product 8", 447m },
                    { 7, "Description for product 7", "Product 7", 381m },
                    { 6, "Description for product 6", "Product 6", 981m },
                    { 5, "Description for product 5", "Product 5", 752m },
                    { 4, "Description for product 4", "Product 4", 125m },
                    { 3, "Description for product 3", "Product 3", 334m },
                    { 2, "Description for product 2", "Product 2", 653m },
                    { 23, "Description for product 23", "Product 23", 181m },
                    { 24, "Description for product 24", "Product 24", 972m },
                    { 25, "Description for product 25", "Product 25", 274m },
                    { 26, "Description for product 26", "Product 26", 627m },
                    { 48, "Description for product 48", "Product 48", 512m },
                    { 47, "Description for product 47", "Product 47", 312m },
                    { 46, "Description for product 46", "Product 46", 543m },
                    { 45, "Description for product 45", "Product 45", 182m },
                    { 44, "Description for product 44", "Product 44", 590m },
                    { 43, "Description for product 43", "Product 43", 917m },
                    { 42, "Description for product 42", "Product 42", 624m },
                    { 41, "Description for product 41", "Product 41", 750m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 544m },
                    { 39, "Description for product 39", "Product 39", 515m },
                    { 99, "Description for product 99", "Product 99", 305m },
                    { 38, "Description for product 38", "Product 38", 252m },
                    { 36, "Description for product 36", "Product 36", 785m },
                    { 35, "Description for product 35", "Product 35", 751m },
                    { 34, "Description for product 34", "Product 34", 557m },
                    { 33, "Description for product 33", "Product 33", 222m },
                    { 32, "Description for product 32", "Product 32", 839m },
                    { 31, "Description for product 31", "Product 31", 286m },
                    { 30, "Description for product 30", "Product 30", 420m },
                    { 29, "Description for product 29", "Product 29", 275m },
                    { 28, "Description for product 28", "Product 28", 615m },
                    { 27, "Description for product 27", "Product 27", 326m },
                    { 37, "Description for product 37", "Product 37", 102m },
                    { 100, "Description for product 100", "Product 100", 653m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 8 },
                    { 73, 73, 13 },
                    { 72, 72, 4 },
                    { 71, 71, 18 },
                    { 70, 70, 16 },
                    { 69, 69, 4 },
                    { 68, 68, 9 },
                    { 67, 67, 16 },
                    { 66, 66, 13 },
                    { 65, 65, 11 },
                    { 64, 64, 4 },
                    { 63, 63, 8 },
                    { 62, 62, 4 },
                    { 61, 61, 18 },
                    { 60, 60, 9 },
                    { 59, 59, 11 },
                    { 58, 58, 2 },
                    { 57, 57, 6 },
                    { 56, 56, 3 },
                    { 55, 55, 11 },
                    { 54, 54, 10 },
                    { 53, 53, 8 },
                    { 74, 74, 11 },
                    { 52, 52, 13 },
                    { 75, 75, 8 },
                    { 77, 77, 11 },
                    { 98, 98, 7 },
                    { 97, 97, 11 },
                    { 96, 96, 18 },
                    { 95, 95, 19 },
                    { 94, 94, 5 },
                    { 93, 93, 0 },
                    { 92, 92, 0 },
                    { 91, 91, 10 },
                    { 90, 90, 6 },
                    { 89, 89, 12 },
                    { 88, 88, 2 },
                    { 87, 87, 6 },
                    { 86, 86, 6 },
                    { 85, 85, 18 },
                    { 84, 84, 17 },
                    { 83, 83, 6 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 14 },
                    { 81, 81, 7 },
                    { 80, 80, 7 },
                    { 79, 79, 5 },
                    { 78, 78, 13 },
                    { 76, 76, 9 },
                    { 51, 51, 14 },
                    { 50, 50, 4 },
                    { 49, 49, 14 },
                    { 22, 22, 4 },
                    { 21, 21, 8 },
                    { 20, 20, 12 },
                    { 19, 19, 9 },
                    { 18, 18, 8 },
                    { 17, 17, 17 },
                    { 16, 16, 1 },
                    { 15, 15, 13 },
                    { 14, 14, 15 },
                    { 13, 13, 14 },
                    { 12, 12, 10 },
                    { 11, 11, 8 },
                    { 10, 10, 11 },
                    { 9, 9, 17 },
                    { 8, 8, 10 },
                    { 7, 7, 5 },
                    { 6, 6, 12 },
                    { 5, 5, 19 },
                    { 4, 4, 4 },
                    { 3, 3, 14 },
                    { 2, 2, 17 },
                    { 23, 23, 11 },
                    { 24, 24, 11 },
                    { 25, 25, 13 },
                    { 26, 26, 10 },
                    { 48, 48, 19 },
                    { 47, 47, 2 },
                    { 46, 46, 5 },
                    { 45, 45, 5 },
                    { 44, 44, 17 },
                    { 43, 43, 12 },
                    { 42, 42, 19 },
                    { 41, 41, 3 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 17 },
                    { 39, 39, 15 },
                    { 99, 99, 6 },
                    { 38, 38, 12 },
                    { 36, 36, 16 },
                    { 35, 35, 10 },
                    { 34, 34, 4 },
                    { 33, 33, 13 },
                    { 32, 32, 15 },
                    { 31, 31, 19 },
                    { 30, 30, 12 },
                    { 29, 29, 1 },
                    { 28, 28, 1 },
                    { 27, 27, 14 },
                    { 37, 37, 3 },
                    { 100, 100, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
