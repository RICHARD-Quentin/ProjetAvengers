using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class fk_correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Coordonnee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee",
                column: "CivilsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Coordonnee");

            migrationBuilder.AddColumn<int>(
                name: "Civils_IdId",
                table: "Coordonnee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
