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
        void Delete(int idProd, int idUser);
        List<ProduitPanier> GetAll(int idUser);
        ProduitPanier GetById(int idPanier, int idUser);
        void Insert(ProduitPanier produitPanier);
        void Update(ProduitPanier produitPanier);
    }
}
