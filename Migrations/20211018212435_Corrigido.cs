using Microsoft.EntityFrameworkCore.Migrations;

namespace NaoUsoMais.Migrations
{
    public partial class Corrigido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teste",
                table: "Produto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "teste",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
