using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVendidos_Compras_CompraId",
                table: "ProdutosVendidos");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVendidos_CompraId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "ProdutosVendidos");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CompraId",
                table: "Produtos",
                column: "CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Compras_CompraId",
                table: "Produtos",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Compras_CompraId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CompraId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "ProdutosVendidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVendidos_CompraId",
                table: "ProdutosVendidos",
                column: "CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVendidos_Compras_CompraId",
                table: "ProdutosVendidos",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id");
        }
    }
}
