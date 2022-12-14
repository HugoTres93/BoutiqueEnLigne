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
        private IUtilisateurRepositories repo;

        public UtilisateurServices(IUtilisateurRepositories repo)
        {
            this.repo = repo;
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public List<Utilisateur> GetAll()
        {
            return repo.GetAll();
        }

        public Utilisateur GetById(int id)
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
