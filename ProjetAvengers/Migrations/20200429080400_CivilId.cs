using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class CivilId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CivilsId",
                table: "Coordonnee",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CivilsId",
                table: "Coordonnee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
