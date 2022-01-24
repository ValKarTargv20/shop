using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shop.Data.Migrations
{
    public partial class FileToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExistingFilePath_Product_ProductId",
                table: "ExistingFilePath");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExistingFilePath",
                table: "ExistingFilePath");

            migrationBuilder.RenameTable(
                name: "ExistingFilePath",
                newName: "ExistingFilePaths");

            migrationBuilder.RenameIndex(
                name: "IX_ExistingFilePath_ProductId",
                table: "ExistingFilePaths",
                newName: "IX_ExistingFilePaths_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExistingFilePaths",
                table: "ExistingFilePaths",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FileToDatabase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SpaceshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileToDatabase", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExistingFilePaths_Product_ProductId",
                table: "ExistingFilePaths",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExistingFilePaths_Product_ProductId",
                table: "ExistingFilePaths");

            migrationBuilder.DropTable(
                name: "FileToDatabase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExistingFilePaths",
                table: "ExistingFilePaths");

            migrationBuilder.RenameTable(
                name: "ExistingFilePaths",
                newName: "ExistingFilePath");

            migrationBuilder.RenameIndex(
                name: "IX_ExistingFilePaths_ProductId",
                table: "ExistingFilePath",
                newName: "IX_ExistingFilePath_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExistingFilePath",
                table: "ExistingFilePath",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExistingFilePath_Product_ProductId",
                table: "ExistingFilePath",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
