using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddValorPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorPago",
                table: "Vendas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorPago",
                table: "VendaParceladas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorPago",
                table: "ComprasParcelada",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorPago",
                table: "Compras",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorPago",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ValorPago",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "ValorPago",
                table: "ComprasParcelada");

            migrationBuilder.DropColumn(
                name: "ValorPago",
                table: "Compras");
        }
    }
}
