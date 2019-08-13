using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateIndicador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Setores_Indicadores_IndicadorId",
                table: "Setores");

            migrationBuilder.DropIndex(
                name: "IX_Setores_IndicadorId",
                table: "Setores");

            migrationBuilder.DropColumn(
                name: "IndicadorId",
                table: "Setores");

            migrationBuilder.AddColumn<int>(
                name: "SetorID",
                table: "Indicadores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Indicadores_SetorID",
                table: "Indicadores",
                column: "SetorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores",
                column: "SetorID",
                principalTable: "Setores",
                principalColumn: "SetorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Indicadores_SetorID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "SetorID",
                table: "Indicadores");

            migrationBuilder.AddColumn<int>(
                name: "IndicadorId",
                table: "Setores",
                nullable: true);

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
    }
}
