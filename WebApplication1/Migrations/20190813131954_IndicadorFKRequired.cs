using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class IndicadorFKRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores");

            migrationBuilder.AlterColumn<int>(
                name: "SetorID",
                table: "Indicadores",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores",
                column: "SetorID",
                principalTable: "Setores",
                principalColumn: "SetorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores");

            migrationBuilder.AlterColumn<int>(
                name: "SetorID",
                table: "Indicadores",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Setores_SetorID",
                table: "Indicadores",
                column: "SetorID",
                principalTable: "Setores",
                principalColumn: "SetorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
