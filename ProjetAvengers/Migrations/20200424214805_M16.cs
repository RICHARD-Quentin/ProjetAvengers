using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class M16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
