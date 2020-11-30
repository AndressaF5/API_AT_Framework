using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Migration002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeReal",
                table: "ListaFavoritos",
                newName: "IdentidadeSecreta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentidadeSecreta",
                table: "ListaFavoritos",
                newName: "NomeReal");
        }
    }
}
