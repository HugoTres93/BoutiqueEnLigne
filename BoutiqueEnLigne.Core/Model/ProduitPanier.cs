using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class ProduitPanier
    {
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
    }
}
