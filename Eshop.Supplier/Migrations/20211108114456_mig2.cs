using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Supplier.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Categroy_CategoryCategroyId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_CategoryCategroyId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CategoryCategroyId",
                table: "Item");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategroyId",
                table: "Item",
                column: "CategroyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Categroy_CategroyId",
                table: "Item",
                column: "CategroyId",
                principalTable: "Categroy",
                principalColumn: "CategroyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Categroy_CategroyId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_CategroyId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "CategoryCategroyId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryCategroyId",
                table: "Item",
                column: "CategoryCategroyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Categroy_CategoryCategroyId",
                table: "Item",
                column: "CategoryCategroyId",
                principalTable: "Categroy",
                principalColumn: "CategroyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
