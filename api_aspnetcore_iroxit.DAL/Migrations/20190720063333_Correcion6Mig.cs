using Microsoft.EntityFrameworkCore.Migrations;

namespace api_aspnetcore_iroxit.DAL.Migrations
{
    public partial class Correcion6Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_IDProductos",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_IDProductos",
                table: "Ventas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IDProductos",
                table: "Ventas",
                column: "IDProductos");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_IDProductos",
                table: "Ventas",
                column: "IDProductos",
                principalTable: "Productos",
                principalColumn: "IDProductos",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
