using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoutiqueEnLigne.Core.Migrations
{
    public partial class PanierUtilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Panier_PanierId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateurs_Panier_PanierId",
                table: "Utilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateurs_PanierId",
                table: "Utilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Produits_PanierId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "Produits");

            migrationBuilder.AlterColumn<int>(
                name: "UtilisateurId",
                table: "Panier",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PanierUtilisateurs",
                columns: table => new
                {
                    PanierId = table.Column<int>(type: "int", nullable: false),
                    ProduitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierUtilisateurs", x => new { x.PanierId, x.ProduitsId });
                    table.ForeignKey(
                        name: "FK_PanierUtilisateurs_Panier_PanierId",
                        column: x => x.PanierId,
                        principalTable: "Panier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PanierUtilisateurs_Produits_ProduitsId",
                        column: x => x.ProduitsId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Panier_UtilisateurId",
                table: "Panier",
                column: "UtilisateurId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PanierUtilisateurs_ProduitsId",
                table: "PanierUtilisateurs",
                column: "ProduitsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Utilisateurs_UtilisateurId",
                table: "Panier",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Utilisateurs_UtilisateurId",
                table: "Panier");

            migrationBuilder.DropTable(
                name: "PanierUtilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Panier_UtilisateurId",
                table: "Panier");

            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "Utilisateurs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UtilisateurId",
                table: "Panier",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PanierId",
                table: "Utilisateurs",
                column: "PanierId",
                unique: true,
                filter: "[PanierId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_PanierId",
                table: "Produits",
                column: "PanierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Panier_PanierId",
                table: "Produits",
                column: "PanierId",
                principalTable: "Panier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateurs_Panier_PanierId",
                table: "Utilisateurs",
                column: "PanierId",
                principalTable: "Panier",
                principalColumn: "Id");
        }
    }
}
