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
    public class ProduitRepositories : IProduitRepositories
    {
        private MyContext _context;

        public ProduitRepositories(MyContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            Produit p = _context.Produits.Find(id);
            if (p != null)
            {
                _context.Produits.Remove(p);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produit introuvable");
            }
        }

        public List<Produit> GetAll()
        {
            return _context.Produits.AsNoTracking().ToList();
        }

        public Produit GetById(int id)
        {
            Produit p = _context.Produits.Find(id);
            if (p != null)
            {
                return p;
            }
            else
            {
                throw new Exception("Produit introuvable");
            }
        }

        public async void Insert(Produit produit)
        {
            _context.Add(produit);
            _context.SaveChanges();
        }

        public void Update(Produit produit)
        {
            Produit ProduitDb = _context.Produits.Find(produit.Id);
            if (ProduitDb != null)
            {
                ProduitDb.Nom = produit.Nom;
                ProduitDb.Description = produit.Description;
                ProduitDb.Image = produit.Image;
                ProduitDb.Prix = produit.Prix;
                ProduitDb.Paniers = produit.Paniers;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produit introuvable");
            }
        }
    }
}
