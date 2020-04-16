using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class organisation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Coordonnee",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Derniere_modification",
                table: "Civils",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_de_naissance",
                table: "Civils",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_de_deces",
                table: "Civils",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Organisation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Dirigeant = table.Column<string>(nullable: true),
                    Telephone_Portable = table.Column<string>(nullable: true),
                    Date_de_creation = table.Column<DateTime>(nullable: false),
                    Derniere_modification = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee",
                column: "OrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Organisation_OrganisationId",
                table: "Coordonnee",
                column: "OrganisationId",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Organisation_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropTable(
                name: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Coordonnee");

            migrationBuilder.AlterColumn<string>(
                name: "Derniere_modification",
                table: "Civils",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Date_de_naissance",
                table: "Civils",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Date_de_deces",
                table: "Civils",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
