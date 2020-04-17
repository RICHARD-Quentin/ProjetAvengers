using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ChangementTypeDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CivilsDTO");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Super_Vilain",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "pouvoir",
                table: "Super_Vilain",
                newName: "Pouvoir");

            migrationBuilder.RenameColumn(
                name: "point_faible",
                table: "Super_Vilain",
                newName: "Point_faible");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Super_Hero",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "pouvoir",
                table: "Super_Hero",
                newName: "Pouvoir");

            migrationBuilder.RenameColumn(
                name: "point_faible",
                table: "Super_Hero",
                newName: "Point_faible");

            migrationBuilder.RenameColumn(
                name: "est_Principale",
                table: "Coordonnee",
                newName: "Est_Principale");

            migrationBuilder.AlterColumn<string>(
                name: "Derniere_modification",
                table: "Civils",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Date_de_naissance",
                table: "Civils",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Date_de_deces",
                table: "Civils",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Super_Vilain",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "Pouvoir",
                table: "Super_Vilain",
                newName: "pouvoir");

            migrationBuilder.RenameColumn(
                name: "Point_faible",
                table: "Super_Vilain",
                newName: "point_faible");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Super_Hero",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "Pouvoir",
                table: "Super_Hero",
                newName: "pouvoir");

            migrationBuilder.RenameColumn(
                name: "Point_faible",
                table: "Super_Hero",
                newName: "point_faible");

            migrationBuilder.RenameColumn(
                name: "Est_Principale",
                table: "Coordonnee",
                newName: "est_Principale");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Derniere_modification",
                table: "Civils",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_de_naissance",
                table: "Civils",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_de_deces",
                table: "Civils",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CivilsDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivilsDTO", x => x.Id);
                });
        }
    }
}
