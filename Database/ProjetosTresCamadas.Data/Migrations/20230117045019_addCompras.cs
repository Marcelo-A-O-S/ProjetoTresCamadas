using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class addCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "ProdutosVendidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDePagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeComprados = table.Column<int>(type: "int", nullable: false),
                    DataDaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagamentoRealizado = table.Column<bool>(type: "bit", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    NomeFantasiaFornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVendidos_CompraId",
                table: "ProdutosVendidos",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_FornecedorId",
                table: "Compras",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_FuncionarioId",
                table: "Compras",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVendidos_Compras_CompraId",
                table: "ProdutosVendidos",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVendidos_Compras_CompraId",
                table: "ProdutosVendidos");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVendidos_CompraId",
                table: "ProdutosVendidos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "ProdutosVendidos");
        }
    }
}
