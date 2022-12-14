using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    internal interface IUtilisateurRepositories
    {
        void Delete(int id);
        List<Utilisateur> GetAll();
        Utilisateur GetById(int id);
        void Insert(Utilisateur utilisateur);
        void Update(Utilisateur utilisateur);
    }
}
