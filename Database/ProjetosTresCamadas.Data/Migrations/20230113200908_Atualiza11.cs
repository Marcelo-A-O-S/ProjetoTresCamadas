using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeVendidos",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "ProdutosVendidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CategoriaNome",
                table: "ProdutosVendidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVendidos_CategoriaId",
                table: "ProdutosVendidos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVendidos_Categorias_CategoriaId",
                table: "ProdutosVendidos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVendidos_Categorias_CategoriaId",
                table: "ProdutosVendidos");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVendidos_CategoriaId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "QuantidadeVendidos",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "CategoriaNome",
                table: "ProdutosVendidos");
        }
    }
}
