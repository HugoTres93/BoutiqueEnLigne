using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public class ProduitPanierServices : IProduitPanierServices
    {
        private IProduitPanierServices repo;

        public ProduitPanierServices(IProduitPanierServices repo)
        {
            this.repo = repo;
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public List<Produits> GetAll()
        {
            return repo.GetAll();
        }

        public Produits GetById(int id)
        {  
            return repo.GetById(id);
        }

        public void Insert(ProduitPanier produitPanier)
        {
            repo.Insert(produitPanier);
        }

        public void Update(ProduitPanier produitPanier)
        {
            repo.Update(produitPanier);
        }
    }
}
