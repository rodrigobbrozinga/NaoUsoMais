using Microsoft.EntityFrameworkCore.Migrations;

namespace NaoUsoMais.Migrations
{
    public partial class correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "teste",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teste",
                table: "Produto");
        }
    }
}
