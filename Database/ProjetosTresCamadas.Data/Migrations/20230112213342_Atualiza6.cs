using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "VendaParceladas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VendaParceladas_VendaId",
                table: "VendaParceladas",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaParceladas_Vendas_VendaId",
                table: "VendaParceladas",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaParceladas_Vendas_VendaId",
                table: "VendaParceladas");

            migrationBuilder.DropIndex(
                name: "IX_VendaParceladas_VendaId",
                table: "VendaParceladas");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "VendaParceladas");
        }
    }
}
