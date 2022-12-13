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
    internal class PanierUtilisateurConfiguration : IEntityTypeConfiguration<PanierUtilisateur>
    {
        public void Configure(EntityTypeBuilder<PanierUtilisateur> builder)
        {
            builder.HasKey(pu => new { pu.PanierId, pu.ProduitsId });
            builder.HasOne(pu => pu.Panier)
                .WithMany(p => p.PanierUtilisateur)
                .HasForeignKey(pu => pu.PanierId);
            builder.HasOne(pu => pu.Produit)
                .WithMany(p => p.PanierUtilisateur)
                .HasForeignKey(pu => pu.ProduitsId);
        }
    }
}
