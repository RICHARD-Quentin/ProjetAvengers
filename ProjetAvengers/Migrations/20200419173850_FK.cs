using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Mission_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                table: "Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Rapport_Mission_Mission_MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Liste_SuperHero_MissionId",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Rapport_Mission_MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_Liste_SuperHero_MissionId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_Liste_SuperVilain_MissionId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_MissionId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Liste_SuperHero_MissionId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "MissionId",
                table: "Rapport_Mission");

            migrationBuilder.DropColumn(
                name: "Liste_SuperHero_MissionId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_MissionId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "Id_crise",
                table: "Liste_sv_crise");

            migrationBuilder.DropColumn(
                name: "Id_supervilain",
                table: "Liste_sv_crise");

            migrationBuilder.DropColumn(
                name: "Id_crise",
                table: "Liste_sh_crise");

            migrationBuilder.DropColumn(
                name: "Id_superhero",
                table: "Liste_sh_crise");

            migrationBuilder.DropColumn(
                name: "Id_crise",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Id_litige",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Identite_origine_appel",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Litige",
                table: "Crise");

            migrationBuilder.AddColumn<int>(
                name: "Civil",
                table: "Utilisateur",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Orga",
                table: "Utilisateur",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_Vilain",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_Hero",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Satisfaction",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission_Incident",
                table: "Rapport_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Rapport_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Privileges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "Privileges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Incident",
                table: "Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crises",
                table: "Litige",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Litige",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crise",
                table: "Liste_sv_crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission",
                table: "Liste_SuperVilain_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission",
                table: "Liste_SuperHero_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crise",
                table: "Liste_sh_crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Origine_Appel",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Declanche_Litige",
                table: "Crise",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Incident",
                table: "Crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModulesId",
                table: "Crise",
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
                name: "IX_Super_Vilain_Liste_SuperVilain_CriseId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_CriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Super_Vilain",
                table: "Super_Vilain",
                column: "Super_Vilain");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_SuperVilain_CriseId",
                table: "Super_Hero",
                column: "Liste_SuperVilain_CriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Super_Hero",
                table: "Super_Hero",
                column: "Super_Hero");

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
                name: "IX_Mission_OrganisationId",
                table: "Mission",
                column: "OrganisationId");

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
                name: "IX_Liste_sv_crise_Crise",
                table: "Liste_sv_crise",
                column: "Crise",
                unique: true,
                filter: "[Crise] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperVilain_Mission_Mission",
                table: "Liste_SuperVilain_Mission",
                column: "Mission",
                unique: true,
                filter: "[Mission] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperHero_Mission_Mission",
                table: "Liste_SuperHero_Mission",
                column: "Mission",
                unique: true,
                filter: "[Mission] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_sh_crise_Crise",
                table: "Liste_sh_crise",
                column: "Crise",
                unique: true,
                filter: "[Crise] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CivilsId",
                table: "Incidents",
                column: "CivilsId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ModulesId",
                table: "Incidents",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_OrganisationId",
                table: "Incidents",
                column: "OrganisationId");

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
                name: "FK_Incidents_Civils_CivilsId",
                table: "Incidents",
                column: "CivilsId",
                principalTable: "Civils",
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
                name: "FK_Incidents_Organisation_OrganisationId",
                table: "Incidents",
                column: "OrganisationId",
                principalTable: "Organisation",
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
                name: "FK_Liste_sh_crise_Crise_Crise",
                table: "Liste_sh_crise",
                column: "Crise",
                principalTable: "Crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_SuperHero_Mission_Mission_Mission",
                table: "Liste_SuperHero_Mission",
                column: "Mission",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_SuperVilain_Mission_Mission_Mission",
                table: "Liste_SuperVilain_Mission",
                column: "Mission",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_sv_crise_Crise_Crise",
                table: "Liste_sv_crise",
                column: "Crise",
                principalTable: "Crise",
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
                name: "FK_Mission_Organisation_OrganisationId",
                table: "Mission",
                column: "OrganisationId",
                principalTable: "Organisation",
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
                name: "FK_Super_Hero_Liste_sh_crise_Liste_SuperVilain_CriseId",
                table: "Super_Hero",
                column: "Liste_SuperVilain_CriseId",
                principalTable: "Liste_sh_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_Hero",
                table: "Super_Hero",
                column: "Super_Hero",
                principalTable: "Liste_SuperHero_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Liste_SuperVilain_CriseId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_CriseId",
                principalTable: "Liste_sv_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_Vilain",
                table: "Super_Vilain",
                column: "Super_Vilain",
                principalTable: "Liste_SuperVilain_Mission",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Incidents_Incident",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Crise_Modules_ModulesId",
                table: "Crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Civils_CivilsId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Modules_ModulesId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Organisation_OrganisationId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Utilisateur_Origine_Appel",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_sh_crise_Crise_Crise",
                table: "Liste_sh_crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_SuperHero_Mission_Mission_Mission",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_SuperVilain_Mission_Mission_Mission",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_sv_crise_Crise_Crise",
                table: "Liste_sv_crise");

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
                name: "FK_Mission_Organisation_OrganisationId",
                table: "Mission");

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
                name: "FK_Super_Hero_Liste_sh_crise_Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_Hero",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_Vilain",
                table: "Super_Vilain");

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
                name: "IX_Super_Vilain_Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Super_Vilain",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Super_Hero",
                table: "Super_Hero");

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
                name: "IX_Mission_Incident",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_ModulesId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Mission_OrganisationId",
                table: "Mission");

            migrationBuilder.DropIndex(
                name: "IX_Litige_Crises",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Litige_ModulesId",
                table: "Litige");

            migrationBuilder.DropIndex(
                name: "IX_Liste_sv_crise_Crise",
                table: "Liste_sv_crise");

            migrationBuilder.DropIndex(
                name: "IX_Liste_SuperVilain_Mission_Mission",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Liste_SuperHero_Mission_Mission",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Liste_sh_crise_Crise",
                table: "Liste_sh_crise");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_CivilsId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ModulesId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_OrganisationId",
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

            migrationBuilder.DropColumn(
                name: "Civil",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "Orga",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Super_Vilain",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Super_Hero",
                table: "Super_Hero");

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
                name: "Incident",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Mission");

            migrationBuilder.DropColumn(
                name: "Crises",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Litige");

            migrationBuilder.DropColumn(
                name: "Crise",
                table: "Liste_sv_crise");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropColumn(
                name: "Crise",
                table: "Liste_sh_crise");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Origine_Appel",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Declanche_Litige",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "Incident",
                table: "Crise");

            migrationBuilder.DropColumn(
                name: "ModulesId",
                table: "Crise");

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_MissionId",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperHero_MissionId",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MissionId",
                table: "Rapport_Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperHero_MissionId",
                table: "Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_MissionId",
                table: "Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_crise",
                table: "Liste_sv_crise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_supervilain",
                table: "Liste_sv_crise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_crise",
                table: "Liste_sh_crise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_superhero",
                table: "Liste_sh_crise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_crise",
                table: "Incidents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_litige",
                table: "Incidents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Identite_origine_appel",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Litige",
                table: "Crise",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_MissionId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_SuperHero_MissionId",
                table: "Super_Hero",
                column: "Liste_SuperHero_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Mission_MissionId",
                table: "Rapport_Mission",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_Liste_SuperHero_MissionId",
                table: "Mission",
                column: "Liste_SuperHero_MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mission_Liste_SuperVilain_MissionId",
                table: "Mission",
                column: "Liste_SuperVilain_MissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Liste_SuperHero_Mission_Liste_SuperHero_MissionId",
                table: "Mission",
                column: "Liste_SuperHero_MissionId",
                principalTable: "Liste_SuperHero_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mission_Liste_SuperVilain_Mission_Liste_SuperVilain_MissionId",
                table: "Mission",
                column: "Liste_SuperVilain_MissionId",
                principalTable: "Liste_SuperVilain_Mission",
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
    }
}
