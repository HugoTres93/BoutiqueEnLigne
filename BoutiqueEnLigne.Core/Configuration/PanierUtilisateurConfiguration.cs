using BoutiqueEnLigne.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Voir : https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration

namespace BoutiqueEnLigne.Core.Configuration
{
    internal class PanierConfiguration : IEntityTypeConfiguration<ProduitPanier>
    {
        public void Configure(EntityTypeBuilder<ProduitPanier> builder)
        {

            builder.HasKey(p => new { p.UtilisateurId, p.ProduitsId });
            // Utilisateur vers panier one to many
            builder.HasOne(p => p.Utilisateur)
                .WithMany(p => p.Panier)
                .HasForeignKey(p => p.UtilisateurId);
            // Produit vers panier one to many
            builder.HasOne(p => p.Produit)
                .WithMany(p => p.Paniers)
                .HasForeignKey(p => p.ProduitsId);
        }
    }
}
