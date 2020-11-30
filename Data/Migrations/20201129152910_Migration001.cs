using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Migration001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaFavoritos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdSuperHero = table.Column<int>(nullable: false),
                    NomeHero = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    Editora = table.Column<string>(nullable: true),
                    Apelido = table.Column<string>(nullable: true),
                    Inteligencia = table.Column<string>(nullable: true),
                    Forca = table.Column<string>(nullable: true),
                    Velocidade = table.Column<string>(nullable: true),
                    Durabilidade = table.Column<string>(nullable: true),
                    Poder = table.Column<string>(nullable: true),
                    Combate = table.Column<string>(nullable: true),
                    NomeReal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaFavoritos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaFavoritos");
        }
    }
}
