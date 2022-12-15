using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    internal class ProduitPanierRepositories : IProduitPanierRepositories
    {
        private MyContext _context;

        public ProduitPanierRepositories(MyContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            ProduitPanier pp = _context.ProduitsPaniers.Find(id);
            if (pp != null)
            {
                _context.ProduitsPaniers.Remove(pp);
                _context.SaveChanges();
            }
        }

        public List<ProduitPanier> GetAll()
        {
            return _context.ProduitsPaniers.ToList();
        }

        public ProduitPanier GetById(int id)
        {
            ProduitPanier pp = _context.ProduitsPaniers.Find(id);
            if (pp != null)
            {
                return pp;
            }
            else
            {
                throw new Exception("Panier introuvable");
            }
        }

        public void Insert(ProduitPanier produitPanier)
        {
            _context.Add(produitPanier);
            _context.SaveChanges();
        }

        public void Update(ProduitPanier produitPanier)
        {
            ProduitPanier PanierDb = _context.ProduitsPaniers.Find(produitPanier.ProduitsId);
            if (PanierDb != null)
            {
                // Pas sure
                PanierDb.Produit = produitPanier.Produit;
                PanierDb.Utilisateur = produitPanier.Utilisateur;

                // PanierDb.UtilisateurId = produitPanier.UtilisateurId;
                // PanierDb.ProduitsId = produitPanier.ProduitsId;
                
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Panier introuvable");
            }
        }
    }
}
