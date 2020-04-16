using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ModuleOrange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Organisation_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Coordonnee");

            migrationBuilder.AlterColumn<int>(
                name: "Dirigeant",
                table: "Organisation",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Civils_IdId",
                table: "Coordonnee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Organisation_IdId",
                table: "Coordonnee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Membre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CivilsId = table.Column<int>(nullable: true),
                    OrganisationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Membre_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Membre_Organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Super_Hero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    pouvoir = table.Column<string>(nullable: true),
                    point_faible = table.Column<string>(nullable: true),
                    score = table.Column<int>(nullable: false),
                    Civils = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Super_Hero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Super_Hero_Civils_Civils",
                        column: x => x.Civils,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Super_Vilain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    pouvoir = table.Column<string>(nullable: true),
                    point_faible = table.Column<string>(nullable: true),
                    score = table.Column<int>(nullable: false),
                    Civils = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Super_Vilain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Super_Vilain_Civils_Civils",
                        column: x => x.Civils,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_Dirigeant",
                table: "Organisation",
                column: "Dirigeant",
                unique: true,
                filter: "[Dirigeant] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Organisation_IdId",
                table: "Coordonnee",
                column: "Organisation_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_CivilsId",
                table: "Membre",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_OrganisationId",
                table: "Membre",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Civils",
                table: "Super_Hero",
                column: "Civils",
                unique: true,
                filter: "[Civils] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Civils",
                table: "Super_Vilain",
                column: "Civils",
                unique: true,
                filter: "[Civils] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Organisation_Organisation_IdId",
                table: "Coordonnee",
                column: "Organisation_IdId",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisation_Civils_Dirigeant",
                table: "Organisation",
                column: "Dirigeant",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Organisation_Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_Civils_Dirigeant",
                table: "Organisation");

            migrationBuilder.DropTable(
                name: "Membre");

            migrationBuilder.DropTable(
                name: "Super_Hero");

            migrationBuilder.DropTable(
                name: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_Dirigeant",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.AlterColumn<string>(
                name: "Dirigeant",
                table: "Organisation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Coordonnee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Coordonnee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee",
                column: "OrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordonnee_Organisation_OrganisationId",
                table: "Coordonnee",
                column: "OrganisationId",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
