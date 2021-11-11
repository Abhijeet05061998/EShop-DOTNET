using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Supplier.Migrations
{
    public partial class CreateMyShowDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categroy",
                columns: table => new
                {
                    CategroyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategroyName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categroy", x => x.CategroyId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "Char(5)", maxLength: 5, nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    CategroyId = table.Column<int>(type: "int", nullable: false),
                    CategoryCategroyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Categroy_CategoryCategroyId",
                        column: x => x.CategoryCategroyId,
                        principalTable: "Categroy",
                        principalColumn: "CategroyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryCategroyId",
                table: "Item",
                column: "CategoryCategroyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Categroy");
        }
    }
}
