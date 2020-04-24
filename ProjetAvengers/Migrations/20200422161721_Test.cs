using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Civils",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Civilite = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Telephone_portable = table.Column<string>(nullable: true),
                    Nationalite = table.Column<string>(nullable: true),
                    Date_de_naissance = table.Column<DateTime>(type: "date", nullable: false),
                    Date_de_deces = table.Column<DateTime>(type: "date", nullable: false),
                    Derniere_modification = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Civils", x => x.Id);
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
                name: "Organisation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Telephone_Portable = table.Column<string>(nullable: true),
                    Date_de_creation = table.Column<DateTime>(type: "date", nullable: false),
                    Derniere_modification = table.Column<DateTime>(type: "date", nullable: false),
                    CivilsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organisation_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    Est_Principale = table.Column<bool>(nullable: false),
                    CivilsId = table.Column<int>(nullable: true),
                    OrganisationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordonnee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordonnee_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordonnee_Organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudo = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Mot_de_passe = table.Column<string>(nullable: true),
                    CivilsId = table.Column<int>(nullable: true),
                    OrganisationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lieu = table.Column<string>(nullable: true),
                    UtilisateurId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true),
                    CivilsId = table.Column<int>(nullable: true),
                    OrganisationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Role = table.Column<string>(nullable: true),
                    UtilisateurId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Privileges_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Privileges_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Incident_majeur = table.Column<string>(nullable: true),
                    Declanche_Litige = table.Column<bool>(nullable: false),
                    IncidentId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crise_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crise_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    OrganisationId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true),
                    IncidentsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mission_Incidents_IncidentsId",
                        column: x => x.IncidentsId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mission_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mission_Organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Liste_sh_crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_sh_crise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liste_sh_crise_Crise_CriseId",
                        column: x => x.CriseId,
                        principalTable: "Crise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Liste_sv_crise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_sv_crise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liste_sv_crise_Crise_CriseId",
                        column: x => x.CriseId,
                        principalTable: "Crise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Litige",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objet = table.Column<string>(nullable: true),
                    Type_litige = table.Column<string>(nullable: true),
                    CriseId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Litige", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Litige_Crise_CriseId",
                        column: x => x.CriseId,
                        principalTable: "Crise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Litige_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Liste_SuperHero_Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_SuperHero_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liste_SuperHero_Mission_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Liste_SuperVilain_Mission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liste_SuperVilain_Mission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liste_SuperVilain_Mission_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
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
                    MissionId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Rapport_Mission_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
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
                    MissionId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Satisfaction_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
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
                    Pouvoir = table.Column<string>(nullable: true),
                    Point_faible = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: true),
                    CivilsId = table.Column<int>(nullable: true),
                    Liste_Super_Hero_Mission_Id = table.Column<int>(nullable: true),
                    Liste_Super_Hero_Crise_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Super_Hero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Super_Hero_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Super_Hero_Liste_sh_crise_Liste_Super_Hero_Crise_Id",
                        column: x => x.Liste_Super_Hero_Crise_Id,
                        principalTable: "Liste_sh_crise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_Super_Hero_Mission_Id",
                        column: x => x.Liste_Super_Hero_Mission_Id,
                        principalTable: "Liste_SuperHero_Mission",
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
                    Pouvoir = table.Column<string>(nullable: true),
                    Point_faible = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: true),
                    CivilsId = table.Column<int>(nullable: true),
                    Liste_Super_Vilain_Mission_Id = table.Column<int>(nullable: true),
                    Liste_Super_Vilain_Crise_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Super_Vilain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Super_Vilain_Civils_CivilsId",
                        column: x => x.CivilsId,
                        principalTable: "Civils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Super_Vilain_Liste_sv_crise_Liste_Super_Vilain_Crise_Id",
                        column: x => x.Liste_Super_Vilain_Crise_Id,
                        principalTable: "Liste_sv_crise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_Super_Vilain_Mission_Id",
                        column: x => x.Liste_Super_Vilain_Mission_Id,
                        principalTable: "Liste_SuperVilain_Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Crise_IncidentId",
                table: "Crise",
                column: "IncidentId",
                unique: true,
                filter: "[IncidentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Crise_ModuleId",
                table: "Crise",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CivilsId",
                table: "Incidents",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ModuleId",
                table: "Incidents",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_OrganisationId",
                table: "Incidents",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_UtilisateurId",
                table: "Incidents",
                column: "UtilisateurId",
                unique: true,
                filter: "[UtilisateurId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_sh_crise_CriseId",
                table: "Liste_sh_crise",
                column: "CriseId",
                unique: true,
                filter: "[CriseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperHero_Mission_MissionId",
                table: "Liste_SuperHero_Mission",
                column: "MissionId",
                unique: true,
                filter: "[MissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperVilain_Mission_MissionId",
                table: "Liste_SuperVilain_Mission",
                column: "MissionId",
                unique: true,
                filter: "[MissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_sv_crise_CriseId",
                table: "Liste_sv_crise",
                column: "CriseId",
                unique: true,
                filter: "[CriseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Litige_CriseId",
                table: "Litige",
                column: "CriseId",
                unique: true,
                filter: "[CriseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Litige_ModuleId",
                table: "Litige",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_CivilsId",
                table: "Membre",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_OrganisationId",
                table: "Membre",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_IncidentsId",
                table: "Mission",
                column: "IncidentsId",
                unique: true,
                filter: "[IncidentsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_ModuleId",
                table: "Mission",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_OrganisationId",
                table: "Mission",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_CivilsId",
                table: "Organisation",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_ModuleId",
                table: "Privileges",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_UtilisateurId",
                table: "Privileges",
                column: "UtilisateurId",
                unique: true,
                filter: "[UtilisateurId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_MissionId",
                table: "Rapport_Mission",
                column: "MissionId",
                unique: true,
                filter: "[MissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_ModuleId",
                table: "Rapport_Mission",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Satisfaction_MissionId",
                table: "Satisfaction",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Satisfaction_ModuleId",
                table: "Satisfaction",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_CivilsId",
                table: "Super_Hero",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_Super_Hero_Crise_Id",
                table: "Super_Hero",
                column: "Liste_Super_Hero_Crise_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_Super_Hero_Mission_Id",
                table: "Super_Hero",
                column: "Liste_Super_Hero_Mission_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_CivilsId",
                table: "Super_Vilain",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_Super_Vilain_Crise_Id",
                table: "Super_Vilain",
                column: "Liste_Super_Vilain_Crise_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_Super_Vilain_Mission_Id",
                table: "Super_Vilain",
                column: "Liste_Super_Vilain_Mission_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_CivilsId",
                table: "Utilisateur",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_OrganisationId",
                table: "Utilisateur",
                column: "OrganisationId",
                unique: true,
                filter: "[OrganisationId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coordonnee");

            migrationBuilder.DropTable(
                name: "Litige");

            migrationBuilder.DropTable(
                name: "Membre");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "Rapport_Mission");

            migrationBuilder.DropTable(
                name: "Satisfaction");

            migrationBuilder.DropTable(
                name: "Super_Hero");

            migrationBuilder.DropTable(
                name: "Super_Vilain");

            migrationBuilder.DropTable(
                name: "Liste_sh_crise");

            migrationBuilder.DropTable(
                name: "Liste_SuperHero_Mission");

            migrationBuilder.DropTable(
                name: "Liste_sv_crise");

            migrationBuilder.DropTable(
                name: "Liste_SuperVilain_Mission");

            migrationBuilder.DropTable(
                name: "Crise");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Organisation");

            migrationBuilder.DropTable(
                name: "Civils");
        }
    }
}
