using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class addComprasParcelada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComprasParcelada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeParcelas = table.Column<int>(type: "int", nullable: false),
                    ParcelasRestantes = table.Column<int>(type: "int", nullable: false),
                    ValorDaParcela = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorRestante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MesInicial = table.Column<int>(type: "int", nullable: false),
                    MesFinal = table.Column<int>(type: "int", nullable: false),
                    DataPagamentoInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasParcelada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprasParcelada_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprasParcelada_CompraId",
                table: "ComprasParcelada",
                column: "CompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasParcelada");
        }
    }
}
