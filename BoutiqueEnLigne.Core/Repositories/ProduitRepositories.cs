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
    internal class ProduitRepositories : IProduitRepositories
    {
        private MyContext _context;

        public ProduitRepositories(MyContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            Produits p = _context.Produits.Find(id);
            if (p != null)
            {
                _context.Produits.Remove(p);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produits introuvable");
            }
        }

        public List<Produits> GetAll()
        {
            return _context.Produits.AsNoTracking().ToList();
        }

        public Produits GetById(int id)
        {
            Produits p = _context.Produits.Find(id);
            if (p != null)
            {
                return p;
            }
            else
            {
                throw new Exception("Produits introuvable");
            }
        }

        public void Insert(Produits produits)
        {
            _context.Add(produits);
            _context.SaveChanges();
        }

        public void Update(Produits produits)
        {
            Produits ProduitDb = _context.Produits.Find(produits.Id);
            if (ProduitDb != null)
            {
                ProduitDb.Produit = produits.Produit;
                ProduitDb.Description = produits.Description;
                ProduitDb.Image = produits.Image;
                ProduitDb.Prix= produits.Prix;
                ProduitDb.Paniers= produits.Paniers;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produit introuvable");
            }
        }
    }
}
