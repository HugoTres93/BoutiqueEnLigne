using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public class ProduitService : IProduitServices
    {
        private IProduitRepositories repo;

        public ProduitService(IProduitRepositories repo)
        {
            this.repo = repo;
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public List<Produit> GetAll()
        {
            return repo.GetAll();
        }

        public Produit GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Insert(Produit produit)
        {
            repo.Insert(produit);
        }

        public void Update(Produit produit)
        {
            repo.Update(produit);
        }
    }
}
