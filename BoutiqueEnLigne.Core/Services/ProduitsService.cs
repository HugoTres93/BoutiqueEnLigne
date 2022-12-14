using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public class ProduitsService : IProduitsServices
    {
        private IProduitRepositories repo;

        public ProduitsService(IProduitRepositories repo)
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

        public void Insert(Produits produits)
        {
            repo.Insert(produits);
        }

        public void Update(Produits produits)
        {
            repo.Update(produits);
        }
    }
}
