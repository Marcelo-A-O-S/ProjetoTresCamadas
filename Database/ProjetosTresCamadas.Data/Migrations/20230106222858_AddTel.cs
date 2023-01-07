using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosTresCamadas.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Fornecedores");
        }
    }
}
