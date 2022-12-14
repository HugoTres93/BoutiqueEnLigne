using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    public interface IProduitPanierRepositories
    {
        void Delete(int id);
        List<ProduitPanier> GetAll();
        ProduitPanier GetById(int id);
        void Insert(ProduitPanier produitPanier);
        void Update(ProduitPanier produitPanier);
    }
}
