using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class AjoutBleuRougeVert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_MissionId",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperHero_MissionId",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Incident_majeur = table.Column<string>(nullable: true),
                    Litige = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_crise = table.Column<int>(nullable: false),
                    Id_litige = table.Column<int>(nullable: false),
                    Lieu = table.Column<string>(nullable: true),
                    Identite_origine_appel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Liste_sh_crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_crise = table.Column<int>(nullable: false),
                    Id_superhero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_sh_crise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Liste_SuperHero_Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_SuperHero_Mission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Liste_SuperVilain_Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_SuperVilain_Mission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Liste_sv_crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_crise = table.Column<int>(nullable: false),
                    Id_supervilain = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_sv_crise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Litige",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objet = table.Column<string>(nullable: true),
                    Type_litige = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Litige", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_module = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lecture = table.Column<bool>(nullable: false),
                    Ecriture = table.Column<bool>(nullable: false),
                    Modification = table.Column<bool>(nullable: false),
                    Suppression = table.Column<bool>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudo = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Mot_de_passe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nature = table.Column<string>(nullable: true),
                    Titre = table.Column<string>(nullable: true),
                    Itineraire = table.Column<string>(nullable: true),
                    Gravite = table.Column<int>(nullable: false),
                    Date_debut = table.Column<DateTime>(nullable: false),
                    Date_fin = table.Column<DateTime>(nullable: false),
                    Liste_SuperHero_MissionId = table.Column<int>(nullable: true),
                    Liste_SuperVilain_MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mission_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                        column: x => x.Liste_SuperHero_MissionId,
                        principalTable: "Liste_SuperHero_Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mission_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                        column: x => x.Liste_SuperVilain_MissionId,
                        principalTable: "Liste_SuperVilain_Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rapport_Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail_intervention = table.Column<string>(nullable: true),
                    Vilain_intervention = table.Column<string>(nullable: true),
                    Nouveau_Civil = table.Column<string>(nullable: true),
                    MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapport_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rapport_Mission_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Satisfaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cible = table.Column<int>(nullable: false),
                    Format = table.Column<int>(nullable: false),
                    Note = table.Column<int>(nullable: false),
                    Fichiers = table.Column<int>(nullable: false),
                    Type_litige = table.Column<int>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true),
                    MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satisfaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satisfaction_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_MissionId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_SuperHero_MissionId",
                table: "Super_Hero",
                column: "Liste_SuperHero_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_Liste_SuperHero_MissionId",
                table: "Mission",
                column: "Liste_SuperHero_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_Liste_SuperVilain_MissionId",
                table: "Mission",
                column: "Liste_SuperVilain_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_MissionId",
                table: "Rapport_Mission",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Satisfaction_MissionId",
                table: "Satisfaction",
                column: "MissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                table: "Super_Hero",
                column: "Liste_SuperHero_MissionId",
                principalTable: "Liste_SuperHero_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_MissionId",
                principalTable: "Liste_SuperVilain_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropTable(
                name: "Crise");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Liste_sh_crise");

            migrationBuilder.DropTable(
                name: "Liste_sv_crise");

            migrationBuilder.DropTable(
                name: "Litige");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "Rapport_Mission");

            migrationBuilder.DropTable(
                name: "Satisfaction");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Liste_SuperHero_Mission");

            migrationBuilder.DropTable(
                name: "Liste_SuperVilain_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Liste_SuperHero_MissionId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Liste_SuperHero_MissionId",
                table: "Super_Hero");
        }
    }
}
