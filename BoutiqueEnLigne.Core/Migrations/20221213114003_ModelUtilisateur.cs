using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoutiqueEnLigne.Core.Migrations
{
    public partial class ModelUtilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Utilisateurs_UtilisateurId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Panier_UtilisateurId",
                table: "Panier");

            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "Utilisateurs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PanierId1",
                table: "Utilisateurs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Prix",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PanierId1",
                table: "Utilisateurs",
                column: "PanierId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateurs_Panier_PanierId1",
                table: "Utilisateurs",
                column: "PanierId1",
                principalTable: "Panier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateurs_Panier_PanierId1",
                table: "Utilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateurs_PanierId1",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PanierId1",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Produits");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_UtilisateurId",
                table: "Panier",
                column: "UtilisateurId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Utilisateurs_UtilisateurId",
                table: "Panier",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
