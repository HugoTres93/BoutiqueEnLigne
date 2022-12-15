using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    public class ProduitPanierRepositories : IProduitPanierRepositories
    {
        private MyContext _context;

        public ProduitPanierRepositories(MyContext context)
        {
            _context = context;
        }

        public void Delete(int idProduit, int idUser)
        {
            ProduitPanier p = _context.ProduitsPaniers.Find(idProduit, idUser);
            if (p != null)
            {
                _context.ProduitsPaniers.Remove(p);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produit introuvable dans le panier");
            }
        }

        public List<ProduitPanier> GetAll()
        {
            return _context.ProduitsPaniers.AsNoTracking().ToList();
        }

        public ProduitPanier GetById(int idProd, int idUser)
        {
            ProduitPanier p = _context.ProduitsPaniers.Find(idProd, idUser);
            if (p != null)
            {
                return p;
            }
            else
            {
                throw new Exception("Produit introuvable dans le panier");
            }
        }

        public void Insert(ProduitPanier produitPanier)
        {
            _context.Add(produitPanier);
            _context.SaveChanges();
        }

        public void Update(ProduitPanier produitPanier)
        {
            ProduitPanier ProduitPanierDb = _context.ProduitsPaniers.Find(produitPanier.ProduitId, produitPanier.UtilisateurId);
            if (ProduitPanierDb != null)
            {
                ProduitPanierDb.Utilisateur = produitPanier.Utilisateur;
                ProduitPanierDb.Produit = produitPanier.Produit;
             
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produit introuvable dans le panier");
            }
        }
    }
}
