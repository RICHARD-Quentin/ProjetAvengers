using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class coordonees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Secret",
                table: "Civils");

            migrationBuilder.AddColumn<string>(
                name: "Date_de_deces",
                table: "Civils",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date_de_naissance",
                table: "Civils",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Derniere_modification",
                table: "Civils",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationalite",
                table: "Civils",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone_portable",
                table: "Civils",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Coordonnee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_de_voie = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    Code_Postal = table.Column<int>(nullable: false),
                    Ville = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Telephone_fixe = table.Column<string>(nullable: true),
                    est_Principale = table.Column<bool>(nullable: false),
                    Civils_IdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordonnee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordonnee_Civils_Civils_IdId",
                        column: x => x.Civils_IdId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Date_de_deces",
                table: "Civils");

            migrationBuilder.DropColumn(
                name: "Date_de_naissance",
                table: "Civils");

            migrationBuilder.DropColumn(
                name: "Derniere_modification",
                table: "Civils");

            migrationBuilder.DropColumn(
                name: "Nationalite",
                table: "Civils");

            migrationBuilder.DropColumn(
                name: "Telephone_portable",
                table: "Civils");

            migrationBuilder.AddColumn<string>(
                name: "Secret",
                table: "Civils",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
