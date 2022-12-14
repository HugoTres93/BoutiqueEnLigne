using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
using BoutiqueEnLigne.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public class UtilisateurServices : IUtilisateurServices
    {
        private IUtilisateurServices repo;

        public UtilisateurServices(IUtilisateurServices repo)
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

        public void Insert(Utilisateur utilisateur)
        {
            repo.Insert(utilisateur);
        }

        public void Update(Utilisateur utilisateur)
        {
            repo.Update(utilisateur);
        }
    }
}
