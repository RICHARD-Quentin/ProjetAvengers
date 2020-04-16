using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAvengers.Migrations
{
    public partial class ModuleOranges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Civils_Civils",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_Civils",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Civils",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Civils",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Civils",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Civils",
                table: "Super_Hero");

            migrationBuilder.AddColumn<int>(
                name: "Identite",
                table: "Super_Vilain",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Identite",
                table: "Super_Hero",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Identite",
                table: "Super_Vilain",
                column: "Identite",
                unique: true,
                filter: "[Identite] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Identite",
                table: "Super_Hero",
                column: "Identite",
                unique: true,
                filter: "[Identite] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Civils_Identite",
                table: "Super_Hero",
                column: "Identite",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Civils_Identite",
                table: "Super_Vilain",
                column: "Identite",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Super_Hero_Civils_Identite",
                table: "Super_Hero");

            migrationBuilder.DropForeignKey(
                name: "FK_Super_Vilain_Civils_Identite",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Vilain_Identite",
                table: "Super_Vilain");

            migrationBuilder.DropIndex(
                name: "IX_Super_Hero_Identite",
                table: "Super_Hero");

            migrationBuilder.DropColumn(
                name: "Identite",
                table: "Super_Vilain");

            migrationBuilder.DropColumn(
                name: "Identite",
                table: "Super_Hero");

            migrationBuilder.AddColumn<int>(
                name: "Civils",
                table: "Super_Vilain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Civils",
                table: "Super_Hero",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Super_Vilain_Civils",
                table: "Super_Vilain",
                column: "Civils",
                unique: true,
                filter: "[Civils] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Super_Hero_Civils",
                table: "Super_Hero",
                column: "Civils",
                unique: true,
                filter: "[Civils] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Hero_Civils_Civils",
                table: "Super_Hero",
                column: "Civils",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Super_Vilain_Civils_Civils",
                table: "Super_Vilain",
                column: "Civils",
                principalTable: "Civils",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
