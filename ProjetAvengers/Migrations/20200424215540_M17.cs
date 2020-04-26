using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class M17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membre_Civils_CivilsId",
                table: "Membre");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_Civils_CivilsId",
                table: "Organisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain");

            migrationBuilder.AddForeignKey(
                name: "FK_Membre_Civils_CivilsId",
                table: "Membre",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisation_Civils_CivilsId",
                table: "Organisation",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membre_Civils_CivilsId",
                table: "Membre");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_Civils_CivilsId",
                table: "Organisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain");

            migrationBuilder.AddForeignKey(
                name: "FK_Membre_Civils_CivilsId",
                table: "Membre",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisation_Civils_CivilsId",
                table: "Organisation",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
