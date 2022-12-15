using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Adresse { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password { get; set; }
        public ICollection<ProduitPanier> Panier { get; set; }

    }

    public enum TypeUtilisateur
    {
        CLIENT = 1,
        ADMIN
    }
}
