﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Model
{
    public class Panier
    {
        public int Id { get; set; }
        public string UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public List<Produits> Produit { get; set; }
    }
}
