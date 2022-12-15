using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoutiqueEnLigne.Core.Model
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public string Image { get; set; }

        public int Prix { get; set; }
        public ICollection<ProduitPanier> Paniers { get; set; }
    }
}
