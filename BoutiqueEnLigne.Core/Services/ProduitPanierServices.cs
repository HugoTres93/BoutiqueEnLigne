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
        private IProduitPanierRepositories repo;

        public ProduitPanierServices(IProduitPanierRepositories repo)
        {
            this.repo = repo;
        }

        public void Delete(int idProd, int idUser)
        {
            repo.Delete(idProd, idUser);
        }

        public List<ProduitPanier> GetAll(int idUser)
        {
            return repo.GetAll(idUser);
        }

        public ProduitPanier GetById(int idProd, int idUser)
        {
            return repo.GetById(idProd, idUser);
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
