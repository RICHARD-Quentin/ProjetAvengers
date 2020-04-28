using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ChangementsRapportIncident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ttitre",
                table: "Rapport_Mission",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "estTraite",
                table: "Incidents",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ttitre",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "estTraite",
                table: "Incidents");
        }
    }
}
