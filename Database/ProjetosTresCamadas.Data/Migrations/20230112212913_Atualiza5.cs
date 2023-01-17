using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaParceladas_Clientes_ClienteId",
                table: "VendaParceladas");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaParceladas_Funcionarios_FuncionarioId",
                table: "VendaParceladas");

            migrationBuilder.DropIndex(
                name: "IX_VendaParceladas_ClienteId",
                table: "VendaParceladas");

            migrationBuilder.DropIndex(
                name: "IX_VendaParceladas_FuncionarioId",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "ClienteName",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "FuncionarioName",
                table: "VendaParceladas");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Vendas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "VendaParceladas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorRestante",
                table: "VendaParceladas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDaParcela",
                table: "VendaParceladas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotalProduto",
                table: "ProdutosVendidos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotalProduto",
                table: "ProdutosVendidos");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Vendas",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "VendaParceladas",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorRestante",
                table: "VendaParceladas",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDaParcela",
                table: "VendaParceladas",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "VendaParceladas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClienteName",
                table: "VendaParceladas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "VendaParceladas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioName",
                table: "VendaParceladas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_VendaParceladas_ClienteId",
                table: "VendaParceladas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaParceladas_FuncionarioId",
                table: "VendaParceladas",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaParceladas_Clientes_ClienteId",
                table: "VendaParceladas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaParceladas_Funcionarios_FuncionarioId",
                table: "VendaParceladas",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
