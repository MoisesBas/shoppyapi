using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppyEx.Product.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "tblProductBrand",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProductType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblStoredEvent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Payload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStoredEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductBrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductBrand_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalSchema: "dbo",
                        principalTable: "tblProductBrand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalSchema: "dbo",
                        principalTable: "tblProductType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ProductBrandId",
                schema: "dbo",
                table: "tblProduct",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ProductTypeId",
                schema: "dbo",
                table: "tblProduct",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProduct",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblStoredEvent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblProductBrand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblProductType",
                schema: "dbo");
        }
    }
}
