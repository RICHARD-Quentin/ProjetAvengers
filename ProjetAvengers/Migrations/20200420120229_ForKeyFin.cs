using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ForKeyFin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.AddColumn<int>(
                name: "Liste_Super_VilainId",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Liste_Super_HeroId",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Liste_Super_VilainId",
                table: "Super_Vilain",
                column: "Liste_Super_VilainId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Liste_Super_HeroId",
                table: "Super_Hero",
                column: "Liste_Super_HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Liste_Super_HeroId",
                table: "Super_Hero",
                column: "Liste_Super_HeroId",
                principalTable: "Liste_sh_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_Super_HeroId",
                table: "Super_Hero",
                column: "Liste_Super_HeroId",
                principalTable: "Liste_SuperHero_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Liste_Super_VilainId",
                table: "Super_Vilain",
                column: "Liste_Super_VilainId",
                principalTable: "Liste_sv_crise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_Super_VilainId",
                table: "Super_Vilain",
                column: "Liste_Super_VilainId",
                principalTable: "Liste_SuperVilain_Mission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_sh_crise_Liste_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Liste_SuperHero_Mission_Liste_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_sv_crise_Liste_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Liste_SuperVilain_Mission_Liste_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Liste_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Liste_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Liste_Super_VilainId",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Liste_Super_HeroId",
                table: "Super_Hero");

            migrationBuilder.AddColumn<int>(
                name: "Super_VilainId",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Super_HeroId",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Super_VilainId",
                table: "Super_Vilain",
                column: "Super_VilainId");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Super_HeroId",
                table: "Super_Hero",
                column: "Super_HeroId");

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
    }
}
