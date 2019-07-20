using Microsoft.EntityFrameworkCore.Migrations;

namespace api_aspnetcore_iroxit.DAL.Migrations
{
    public partial class Correcion3Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_IDProducto",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "IDProducto",
                table: "Ventas",
                newName: "IDProductos");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_IDProducto",
                table: "Ventas",
                newName: "IX_Ventas_IDProductos");

            migrationBuilder.RenameColumn(
                name: "IDProducto",
                table: "Productos",
                newName: "IDProductos");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_IDProductos",
                table: "Ventas",
                column: "IDProductos",
                principalTable: "Productos",
                principalColumn: "IDProductos",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_IDProductos",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "IDProductos",
                table: "Ventas",
                newName: "IDProducto");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_IDProductos",
                table: "Ventas",
                newName: "IX_Ventas_IDProducto");

            migrationBuilder.RenameColumn(
                name: "IDProductos",
                table: "Productos",
                newName: "IDProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_IDProducto",
                table: "Ventas",
                column: "IDProducto",
                principalTable: "Productos",
                principalColumn: "IDProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
