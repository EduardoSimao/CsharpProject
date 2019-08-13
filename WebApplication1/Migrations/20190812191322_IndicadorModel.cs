using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class IndicadorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndicadorId",
                table: "Setores",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Indicadores",
                columns: table => new
                {
                    IndicadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    Situacao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicadores", x => x.IndicadorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Setores_IndicadorId",
                table: "Setores",
                column: "IndicadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Setores_Indicadores_IndicadorId",
                table: "Setores",
                column: "IndicadorId",
                principalTable: "Indicadores",
                principalColumn: "IndicadorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Setores_Indicadores_IndicadorId",
                table: "Setores");

            migrationBuilder.DropTable(
                name: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Setores_IndicadorId",
                table: "Setores");

            migrationBuilder.DropColumn(
                name: "IndicadorId",
                table: "Setores");
        }
    }
}
