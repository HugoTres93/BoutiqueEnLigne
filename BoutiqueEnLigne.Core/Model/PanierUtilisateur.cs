using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class PanierUtilisateur
    {
        public int? PanierId { get; set; }
        public Panier Panier { get; set; }
        public int ProduitsId { get; set; }
        public Produits Produit { get; set;}

    }
}
