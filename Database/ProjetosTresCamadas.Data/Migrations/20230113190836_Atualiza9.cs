using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "ProdutosVendidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomeCliente",
                table: "ProdutosVendidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVendidos_ClienteId",
                table: "ProdutosVendidos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVendidos_Clientes_ClienteId",
                table: "ProdutosVendidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVendidos_Clientes_ClienteId",
                table: "ProdutosVendidos");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVendidos_ClienteId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "NomeCliente",
                table: "ProdutosVendidos");
        }
    }
}
