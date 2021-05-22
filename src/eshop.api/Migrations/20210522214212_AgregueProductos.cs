using Microsoft.EntityFrameworkCore.Migrations;

namespace eshop.api.Migrations
{
    public partial class AgregueProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Detalles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_ProductoId",
                table: "Detalles",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Productos_ProductoId",
                table: "Detalles",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Productos_ProductoId",
                table: "Detalles");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_ProductoId",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Detalles");
        }
    }
}
