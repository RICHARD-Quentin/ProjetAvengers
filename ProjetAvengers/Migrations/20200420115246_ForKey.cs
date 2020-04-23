using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ForKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Organisation_Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Incidents_Incident",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Modules_ModulesId",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Modules_ModulesId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Utilisateur_Origine_Appel",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Litige_Crise_Crises",
                table: "Litige");

            migrationBuilder.DropForeignKey(
                name: "FK_Litige_Modules_ModulesId",
                table: "Litige");

            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Incidents_Incident",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Modules_ModulesId",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_Civils_Dirigeant",
                table: "Organisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Privileges_Modules_ModulesId",
                table: "Privileges");

            migrationBuilder.DropForeignKey(
                name: "FK_Privileges_Utilisateur_User",
                table: "Privileges");

            migrationBuilder.DropForeignKey(
                name: "FK_Rapport_Mission_Mission_Mission_Incident",
                table: "Rapport_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Rapport_Mission_Modules_ModulesId",
                table: "Rapport_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Satisfaction_Modules_ModulesId",
                table: "Satisfaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Civils_Civil",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Organisation_Orga",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_Civil",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_Orga",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Satisfaction_ModulesId",
                table: "Satisfaction");

            migrationBuilder.DropIndex(
                name: "IX_Rapport_Mission_Mission_Incident",
                table: "Rapport_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Rapport_Mission_ModulesId",
                table: "Rapport_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Privileges_ModulesId",
                table: "Privileges");

            migrationBuilder.DropIndex(
                name: "IX_Privileges_User",
                table: "Privileges");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_Dirigeant",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Mission_Incident",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_ModulesId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Litige_Crises",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Litige_ModulesId",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ModulesId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_Origine_Appel",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Crise_Incident",
                table: "Crise");

            migrationBuilder.DropIndex(
                name: "IX_Crise_ModulesId",
                table: "Crise");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Civil",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "Orga",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Satisfaction");

            migrationBuilder.DropColumn(
                name: "Mission_Incident",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "Dirigeant",
                table: "Organisation");

            migrationBuilder.DropColumn(
                name: "Incident",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "Crises",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Origine_Appel",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Incident",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "Civils_IdId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "Organisation_IdId",
                table: "Coordonnee");

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Utilisateur",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Utilisateur",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Satisfaction",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MissionId",
                table: "Rapport_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Rapport_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Privileges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurId",
                table: "Privileges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Organisation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IncidentsId",
                table: "Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriseId",
                table: "Litige",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Litige",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IncidentId",
                table: "Crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Coordonnee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Coordonnee",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Satisfaction_ModuleId",
                table: "Satisfaction",
                column: "ModuleId");

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
                name: "IX_Organisation_CivilsId",
                table: "Organisation",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

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
                name: "IX_Incidents_ModuleId",
                table: "Incidents",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_UtilisateurId",
                table: "Incidents",
                column: "UtilisateurId",
                unique: true,
                filter: "[UtilisateurId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Crise_Incidents_IncidentId",
                table: "Crise",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crise_Modules_ModuleId",
                table: "Crise",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Modules_ModuleId",
                table: "Incidents",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Utilisateur_UtilisateurId",
                table: "Incidents",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Litige_Crise_CriseId",
                table: "Litige",
                column: "CriseId",
                principalTable: "Crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Litige_Modules_ModuleId",
                table: "Litige",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Incidents_IncidentsId",
                table: "Mission",
                column: "IncidentsId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Modules_ModuleId",
                table: "Mission",
                column: "ModuleId",
                principalTable: "Modules",
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
                name: "FK_Privileges_Modules_ModuleId",
                table: "Privileges",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_Utilisateur_UtilisateurId",
                table: "Privileges",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rapport_Mission_Mission_MissionId",
                table: "Rapport_Mission",
                column: "MissionId",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rapport_Mission_Modules_ModuleId",
                table: "Rapport_Mission",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Satisfaction_Modules_ModuleId",
                table: "Satisfaction",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Civils_CivilsId",
                table: "Utilisateur",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Organisation_OrganisationId",
                table: "Utilisateur",
                column: "OrganisationId",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Civils_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordonnee_Organisation_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Incidents_IncidentId",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Modules_ModuleId",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Modules_ModuleId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Utilisateur_UtilisateurId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Litige_Crise_CriseId",
                table: "Litige");

            migrationBuilder.DropForeignKey(
                name: "FK_Litige_Modules_ModuleId",
                table: "Litige");

            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Incidents_IncidentsId",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Modules_ModuleId",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Organisation_Civils_CivilsId",
                table: "Organisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Privileges_Modules_ModuleId",
                table: "Privileges");

            migrationBuilder.DropForeignKey(
                name: "FK_Privileges_Utilisateur_UtilisateurId",
                table: "Privileges");

            migrationBuilder.DropForeignKey(
                name: "FK_Rapport_Mission_Mission_MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Rapport_Mission_Modules_ModuleId",
                table: "Rapport_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Satisfaction_Modules_ModuleId",
                table: "Satisfaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Civils_CivilsId",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Organisation_OrganisationId",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_CivilsId",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_OrganisationId",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Satisfaction_ModuleId",
                table: "Satisfaction");

            migrationBuilder.DropIndex(
                name: "IX_Rapport_Mission_MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Rapport_Mission_ModuleId",
                table: "Rapport_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Privileges_ModuleId",
                table: "Privileges");

            migrationBuilder.DropIndex(
                name: "IX_Privileges_UtilisateurId",
                table: "Privileges");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_CivilsId",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_Mission_IncidentsId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_ModuleId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Litige_CriseId",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Litige_ModuleId",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ModuleId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_UtilisateurId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Crise_IncidentId",
                table: "Crise");

            migrationBuilder.DropIndex(
                name: "IX_Crise_ModuleId",
                table: "Crise");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropIndex(
                name: "IX_Coordonnee_OrganisationId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Satisfaction");

            migrationBuilder.DropColumn(
                name: "MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "UtilisateurId",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Organisation");

            migrationBuilder.DropColumn(
                name: "IncidentsId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "CriseId",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "UtilisateurId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "IncidentId",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Coordonnee");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Coordonnee");

            migrationBuilder.AddColumn<int>(
                name: "Civil",
                table: "Utilisateur",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Orga",
                table: "Utilisateur",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Satisfaction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission_Incident",
                table: "Rapport_Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Rapport_Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Privileges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "Privileges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dirigeant",
                table: "Organisation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Incident",
                table: "Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crises",
                table: "Litige",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Litige",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Incidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Origine_Appel",
                table: "Incidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Incident",
                table: "Crise",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Crise",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Civils_IdId",
                table: "Coordonnee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Organisation_IdId",
                table: "Coordonnee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_Civil",
                table: "Utilisateur",
                column: "Civil",
                unique: true,
                filter: "[Civil] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_Orga",
                table: "Utilisateur",
                column: "Orga",
                unique: true,
                filter: "[Orga] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Satisfaction_ModulesId",
                table: "Satisfaction",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_Mission_Incident",
                table: "Rapport_Mission",
                column: "Mission_Incident",
                unique: true,
                filter: "[Mission_Incident] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_ModulesId",
                table: "Rapport_Mission",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_ModulesId",
                table: "Privileges",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_User",
                table: "Privileges",
                column: "User",
                unique: true,
                filter: "[User] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_Dirigeant",
                table: "Organisation",
                column: "Dirigeant",
                unique: true,
                filter: "[Dirigeant] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_Incident",
                table: "Mission",
                column: "Incident",
                unique: true,
                filter: "[Incident] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_ModulesId",
                table: "Mission",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Litige_Crises",
                table: "Litige",
                column: "Crises",
                unique: true,
                filter: "[Crises] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Litige_ModulesId",
                table: "Litige",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ModulesId",
                table: "Incidents",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_Origine_Appel",
                table: "Incidents",
                column: "Origine_Appel",
                unique: true,
                filter: "[Origine_Appel] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Crise_Incident",
                table: "Crise",
                column: "Incident",
                unique: true,
                filter: "[Incident] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Crise_ModulesId",
                table: "Crise",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Civils_IdId",
                table: "Coordonnee",
                column: "Civils_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_Organisation_IdId",
                table: "Coordonnee",
                column: "Organisation_IdId");

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
                name: "FK_Crise_Incidents_Incident",
                table: "Crise",
                column: "Incident",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crise_Modules_ModulesId",
                table: "Crise",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Modules_ModulesId",
                table: "Incidents",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Utilisateur_Origine_Appel",
                table: "Incidents",
                column: "Origine_Appel",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Litige_Crise_Crises",
                table: "Litige",
                column: "Crises",
                principalTable: "Crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Litige_Modules_ModulesId",
                table: "Litige",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Incidents_Incident",
                table: "Mission",
                column: "Incident",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Modules_ModulesId",
                table: "Mission",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisation_Civils_Dirigeant",
                table: "Organisation",
                column: "Dirigeant",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_Modules_ModulesId",
                table: "Privileges",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_Utilisateur_User",
                table: "Privileges",
                column: "User",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rapport_Mission_Mission_Mission_Incident",
                table: "Rapport_Mission",
                column: "Mission_Incident",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rapport_Mission_Modules_ModulesId",
                table: "Rapport_Mission",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Satisfaction_Modules_ModulesId",
                table: "Satisfaction",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Civils_Civil",
                table: "Utilisateur",
                column: "Civil",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Organisation_Orga",
                table: "Utilisateur",
                column: "Orga",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
