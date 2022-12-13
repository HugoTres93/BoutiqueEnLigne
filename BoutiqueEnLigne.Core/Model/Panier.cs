using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class Panier
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public ICollection<PanierUtilisateur> PanierUtilisateur { get; set; }
    }
}
