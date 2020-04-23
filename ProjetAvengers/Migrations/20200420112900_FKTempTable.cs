using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class FKTempTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Super_Hero_Civils_Identite",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_Hero",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_Identite",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_Vilain",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Identite",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Super_Vilain",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Identite",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Super_Hero",
                table: "Super_Hero");

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

            migrationBuilder.DropColumn(
                name: "Identite",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Super_Vilain",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Identite",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Super_Hero",
                table: "Super_Hero");

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

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_VilainId",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CivilsId",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_HeroId",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriseId",
                table: "Liste_sv_crise",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MissionId",
                table: "Liste_SuperVilain_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MissionId",
                table: "Liste_SuperHero_Mission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriseId",
                table: "Liste_sh_crise",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_CivilsId",
                table: "Super_Vilain",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Super_VilainId",
                table: "Super_Vilain",
                column: "Super_VilainId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_CivilsId",
                table: "Super_Hero",
                column: "CivilsId",
                unique: true,
                filter: "[CivilsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Super_HeroId",
                table: "Super_Hero",
                column: "Super_HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_sv_crise_CriseId",
                table: "Liste_sv_crise",
                column: "CriseId",
                unique: true,
                filter: "[CriseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperVilain_Mission_MissionId",
                table: "Liste_SuperVilain_Mission",
                column: "MissionId",
                unique: true,
                filter: "[MissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_SuperHero_Mission_MissionId",
                table: "Liste_SuperHero_Mission",
                column: "MissionId",
                unique: true,
                filter: "[MissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Liste_sh_crise_CriseId",
                table: "Liste_sh_crise",
                column: "CriseId",
                unique: true,
                filter: "[CriseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_sh_crise_Crise_CriseId",
                table: "Liste_sh_crise",
                column: "CriseId",
                principalTable: "Crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_SuperHero_Mission_Mission_MissionId",
                table: "Liste_SuperHero_Mission",
                column: "MissionId",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_SuperVilain_Mission_Mission_MissionId",
                table: "Liste_SuperVilain_Mission",
                column: "MissionId",
                principalTable: "Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liste_sv_crise_Crise_CriseId",
                table: "Liste_sv_crise",
                column: "CriseId",
                principalTable: "Crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Super_HeroId",
                table: "Super_Hero",
                column: "Super_HeroId",
                principalTable: "Liste_sh_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_HeroId",
                table: "Super_Hero",
                column: "Super_HeroId",
                principalTable: "Liste_SuperHero_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain",
                column: "CivilsId",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Super_VilainId",
                table: "Super_Vilain",
                column: "Super_VilainId",
                principalTable: "Liste_sv_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_VilainId",
                table: "Super_Vilain",
                column: "Super_VilainId",
                principalTable: "Liste_SuperVilain_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Liste_sh_crise_Crise_CriseId",
                table: "Liste_sh_crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_SuperHero_Mission_Mission_MissionId",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_SuperVilain_Mission_Mission_MissionId",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropForeignKey(
                name: "FK_Liste_sv_crise_Crise_CriseId",
                table: "Liste_sv_crise");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Civils_CivilsId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_CivilsId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_CivilsId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_CivilsId",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropIndex(
                name: "IX_Liste_sv_crise_CriseId",
                table: "Liste_sv_crise");

            migrationBuilder.DropIndex(
                name: "IX_Liste_SuperVilain_Mission_MissionId",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Liste_SuperHero_Mission_MissionId",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropIndex(
                name: "IX_Liste_sh_crise_CriseId",
                table: "Liste_sh_crise");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "CivilsId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "CriseId",
                table: "Liste_sv_crise");

            migrationBuilder.DropColumn(
                name: "MissionId",
                table: "Liste_SuperVilain_Mission");

            migrationBuilder.DropColumn(
                name: "MissionId",
                table: "Liste_SuperHero_Mission");

            migrationBuilder.DropColumn(
                name: "CriseId",
                table: "Liste_sh_crise");

            migrationBuilder.AddColumn<int>(
                name: "Identite",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_Vilain",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Identite",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_SuperVilain_CriseId",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_Hero",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crise",
                table: "Liste_sv_crise",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission",
                table: "Liste_SuperVilain_Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mission",
                table: "Liste_SuperHero_Mission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Crise",
                table: "Liste_sh_crise",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Identite",
                table: "Super_Vilain",
                column: "Identite",
                unique: true,
                filter: "[Identite] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_SuperVilain_CriseId",
                table: "Super_Vilain",
                column: "Liste_SuperVilain_CriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Super_Vilain",
                table: "Super_Vilain",
                column: "Super_Vilain");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Identite",
                table: "Super_Hero",
                column: "Identite",
                unique: true,
                filter: "[Identite] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_SuperVilain_CriseId",
                table: "Super_Hero",
                column: "Liste_SuperVilain_CriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Super_Hero",
                table: "Super_Hero",
                column: "Super_Hero");

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
                name: "FK_Super_Hero_Civils_Identite",
                table: "Super_Hero",
                column: "Identite",
                principalTable: "Civils",
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
                name: "FK_Super_Vilain_Civils_Identite",
                table: "Super_Vilain",
                column: "Identite",
                principalTable: "Civils",
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
        }
    }
}
