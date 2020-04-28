using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class Rapport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ttitre",
                table: "Rapport_Mission");

            migrationBuilder.AddColumn<string>(
                name: "Titre",
                table: "Rapport_Mission",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titre",
                table: "Rapport_Mission");

            migrationBuilder.AddColumn<string>(
                name: "Ttitre",
                table: "Rapport_Mission",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
