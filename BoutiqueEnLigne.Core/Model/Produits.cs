using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class Produits
    {
        public int Id { get; set; }
        public string Produit { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Prix { get; set; }
        public ICollection<PanierUtilisateur>? PanierUtilisateur { get; set; }
    }
}
